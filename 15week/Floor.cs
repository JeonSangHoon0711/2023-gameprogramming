using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        // �浹�� ������Ʈ�� �̸��� 'floor'�� ���
        if (collision.gameObject.name == "Ball")
        {
            // 'GameManager' ������Ʈ�� ã�� 'GameEnd' �Լ��� ȣ���մϴ�.
            GameObject.Find("GameManager").SendMessage("GameEnd");
        }
    }
}
