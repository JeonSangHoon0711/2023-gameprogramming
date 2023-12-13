using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    float point;
    // Start is called before the first frame update
    void Start()
    {
        point = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float distance;
        distance = transform.position.z - point;

        if (Input.GetKeyDown(KeyCode.Space))
        {//점프
            GetComponent<Rigidbody>().AddForce(Vector3.up * 400);
        }

        if (Input.GetKeyDown(KeyCode.W))// 앞
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 400);
        }

        if (Input.GetKeyDown(KeyCode.S))//뒤
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 400);
        }

        if (Input.GetKeyDown(KeyCode.A))//왼
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 400);
        }

        if (Input.GetKeyDown(KeyCode.D))//오
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 400);
        }


        //Debug.Log(distance);

    }
}

