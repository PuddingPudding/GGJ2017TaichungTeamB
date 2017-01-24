using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControll : MonoBehaviour
{
    public GameObject wave;
    public GameObject waveanimation;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject waveCopy = null;
            waveCopy = Instantiate(wave, transform.position, new Quaternion(0, 0, 0, 0));
        }
    }
}
