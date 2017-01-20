using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class background : MonoBehaviour {
    public object dateTime;

    // Use this for initialization
    void Start () {
        dateTime = DateTime.Now.Hour;//抓時間
        




    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
