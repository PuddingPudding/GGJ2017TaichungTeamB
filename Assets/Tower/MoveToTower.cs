using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTower : MonoBehaviour
{
    GameObject target = null;
    public GameObject explo;
    Unit unit;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindWithTag("Tower");
        unit = GetComponent<Unit>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = unit.Speed;
        if(target.transform.position.x > transform.position.x)
        {
            transform.position += new Vector3(unit.Speed * Time.deltaTime, 0 , 0);
        }
        if (target.transform.position.x < transform.position.x)
        {
            transform.position -= new Vector3(unit.Speed * Time.deltaTime  , 0 , 0);
        }
        if (target.transform.position.y > transform.position.y)
        {
            transform.position += new Vector3(0, unit.Speed * Time.deltaTime, 0);
        }
        if (target.transform.position.y < transform.position.y)
        {
            transform.position -= new Vector3(0, unit.Speed * Time.deltaTime, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D col)  //2D觸發事件
    {
        print("trigger out!");
        if (col.tag == "Wave")
        {
            print("trigger!");
            unit.HP -= 1;
            if(unit.HP <= 0)
            {
                Destroy(this.gameObject);
                Instantiate(explo, transform.position, transform.rotation);
            }
        }
    }
}

