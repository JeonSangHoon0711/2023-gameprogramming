using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedStar : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource �߰�
    public AudioClip audioClip; // AudioClip �߰�

    // Start is called before the first frame update
    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 100f) * Time.deltaTime); // ȸ��
    }

    private void OnTriggerEnter(Collider other) // �浹 ����
    {
        if (other.gameObject.name == "Ball")
        {
            PlaySound();
            GameObject.Find("GameManager").SendMessage("GetCoin"); // ���Ӹ޴������� �Լ� �ҷ�����
            float x = Random.Range(-24.0f, 24.0f);
            float y = 0;
            float z = Random.Range(-24.0f, 24.0f);

            // ���� ��ġ�� ������ ������ ����
            transform.position = new Vector3(x, y, z);

            // �Ҹ� ���

            // Sun ��ü�� �������� ���߱�
            GameObject sun = GameObject.Find("Sun");
            if (sun != null)
            {
                Sun sunScript = sun.GetComponent<Sun>();
                if (sunScript != null)
                {
                    sunScript.StopMovingForSeconds(3.0f);
                }
            }
        }
    }

    // �Ҹ� ��� �Լ�
    void PlaySound()
    {
        if (audioSource != null && audioClip != null)
            audioSource.PlayOneShot(audioClip);
    }
}
