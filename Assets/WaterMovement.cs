using UnityEngine;

public class WaterMovement : MonoBehaviour
{

    Material myMaterial;
    float cycle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        myMaterial = sprite.material;
        cycle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cycle += 1;
        if(cycle > 3)
        {
            cycle = 0;
        }
        if(cycle == 0)
        {
            myMaterial.SetFloat("Bool", 0);
            myMaterial.SetFloat("Bool2", 0);
        }
        if(cycle == 1)
        {
            myMaterial.SetFloat("Bool", 1);
            myMaterial.SetFloat("Bool2", 0);
        }
        if(cycle == 2)
        {
            myMaterial.SetFloat("Bool2", 1);
            myMaterial.SetFloat("Bool", 0);
        }

    }
}
