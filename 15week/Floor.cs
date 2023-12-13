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
        // 충돌한 오브젝트의 이름이 'floor'인 경우
        if (collision.gameObject.name == "Ball")
        {
            // 'GameManager' 오브젝트를 찾아 'GameEnd' 함수를 호출합니다.
            GameObject.Find("GameManager").SendMessage("GameEnd");
        }
    }
}
