using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTower : MonoBehaviour
{
    GameObject target = null;
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


}
