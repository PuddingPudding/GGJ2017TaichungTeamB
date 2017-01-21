using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diffusion : MonoBehaviour
{
    public float diffusionSpeed = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale *= (1 + (diffusionSpeed * Time.deltaTime) );
        if(transform.localScale.x > 90f)
        {
            print(transform.localScale.x + " " + transform.localScale.y + " "  + transform.localScale.z);
            DestroyObject(this.gameObject);
        }
    }
}
