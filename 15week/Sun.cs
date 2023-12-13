using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float speed = 0.03f; // �̵� �ӵ�
    private Vector3 direction; // ���� �̵� ����
    private bool isMoving = true; // ���� �����̴� �������� ǥ��

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

        // X�� �Ǵ� Z�� ������ ����ٸ� �ݴ� �������� ����
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
        // ������ ���� ���� (X�� Z �࿡�� -1.0f, 1.0f ����)
        direction = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f)).normalized;
    }

    void MoveInDirection()
    {
        // ���� �������� �̵�
        transform.localPosition += direction * speed;
    }

    private void OnCollisionEnter(Collision collision)//���� ��ֹ� �浹
    {
        Debug.Log(collision.gameObject.name + "�浹");

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
