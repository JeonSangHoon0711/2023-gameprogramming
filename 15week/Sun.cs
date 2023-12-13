using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float speed = 0.03f; // 이동 속도
    private Vector3 direction; // 현재 이동 방향
    private bool isMoving = true; // 현재 움직이는 상태인지 표시

    // Start is called before the first frame update
    void Start()
    {
        ChooseNewDirection();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
            MoveInDirection();

        // X축 또는 Z축 범위를 벗어났다면 반대 방향으로 변경
        if (transform.localPosition.x < -22 || transform.localPosition.x > 22)
        {
            direction.x = -direction.x;
        }
        if (transform.localPosition.z < -22 || transform.localPosition.z > 22)
        {
            direction.z = -direction.z;
        }
    }

    void ChooseNewDirection()
    {
        // 랜덤한 방향 선택 (X와 Z 축에서 -1.0f, 1.0f 사이)
        direction = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f)).normalized;
    }

    void MoveInDirection()
    {
        // 현재 방향으로 이동
        transform.localPosition += direction * speed;
    }

    private void OnCollisionEnter(Collision collision)//공과 장애물 충돌
    {
        Debug.Log(collision.gameObject.name + "충돌");

        GameObject.Find("GameManager").SendMessage("GameEnd");
    }

    public void StopMovingForSeconds(float seconds)
    {
        StartCoroutine(StopMovingCoroutine(seconds));
    }

    private IEnumerator StopMovingCoroutine(float seconds)
    {
        isMoving = false;
        yield return new WaitForSeconds(seconds);
        isMoving = true;
    }
}
