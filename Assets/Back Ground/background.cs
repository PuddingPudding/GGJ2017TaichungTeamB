using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class background : MonoBehaviour
{
    public object dateTime;
    public GameObject Emeny;
    public float time;

    // Use this for initialization
    void Start()
    {
        dateTime = DateTime.Now.Hour;//抓時間





    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; //時間增加
        if (time > 0.4) //如果時間大於0.5(秒)
        {
            Vector3 pos = new Vector3(UnityEngine.Random.Range(-3f, 3f), UnityEngine.Random.Range(-2f, 2f), 0); //宣告位置pos，Random.Range(-2.5f,2.5f)代表X是2.5到-2.5之間隨機
            Instantiate(Emeny, pos, transform.rotation); //產生敵人
            time = 0f; //時間歸零
        }

    }
}
