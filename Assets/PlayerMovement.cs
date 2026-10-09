using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float maxSpeed;
    Vector3 velocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        
        
    }
    void FixedUpdate()
    {
        Debug.Log(Input.GetKeyDown(KeyCode.A));
        if(Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector3(-speed,0,0));
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector3(speed,0,0));
        }
        
    }
}
