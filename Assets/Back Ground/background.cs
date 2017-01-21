using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class background : MonoBehaviour
{
    public object dateTime;
    public GameObject Emeny;
    public float time;
    public float initRange = 6; //生成敵人的範圍

    // Use this for initialization
    void Start()
    {
        dateTime = DateTime.Now.Hour;//抓時間

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; //時間增加
        if (time >= 0.5f) //如果時間大於0.5(秒)
        {
            float IR = initRange;
            Vector3 pos = new Vector3(UnityEngine.Random.Range(-2 * IR, 0), UnityEngine.Random.Range(-2 * IR, 0), 0); //宣告位置pos，Random.Range(-2.5f,2.5f)代表X是2.5到-2.5之間隨機
            if (pos.x > -1 * IR)
            {
                pos.x += 2 * IR;
            }
            if (pos.y > -1 * IR)
            {
                pos.y += 2 * IR;
            }
            Instantiate(Emeny, pos, transform.rotation); //產生敵人
            time = 0f; //時間歸零
        }

    }
}
