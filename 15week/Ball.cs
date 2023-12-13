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
        {//����
            GetComponent<Rigidbody>().AddForce(Vector3.up * 400);
        }

        if (Input.GetKeyDown(KeyCode.W))// ��
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 400);
        }

        if (Input.GetKeyDown(KeyCode.S))//��
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 400);
        }

        if (Input.GetKeyDown(KeyCode.A))//��
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 400);
        }

        if (Input.GetKeyDown(KeyCode.D))//��
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 400);
        }


        //Debug.Log(distance);

    }
}

