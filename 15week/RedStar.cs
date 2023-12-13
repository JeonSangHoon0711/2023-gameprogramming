using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedStar : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource 추가
    public AudioClip audioClip; // AudioClip 추가

    // Start is called before the first frame update
    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 100f) * Time.deltaTime); // 회전
    }

    private void OnTriggerEnter(Collider other) // 충돌 감지
    {
        if (other.gameObject.name == "Ball")
        {
            PlaySound();
            GameObject.Find("GameManager").SendMessage("GetCoin"); // 게임메니저에서 함수 불러오기
            float x = Random.Range(-24.0f, 24.0f);
            float y = 0;
            float z = Random.Range(-24.0f, 24.0f);

            // 별의 위치를 랜덤한 값으로 변경
            transform.position = new Vector3(x, y, z);

            // 소리 재생

            // Sun 객체의 움직임을 멈추기
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

    // 소리 재생 함수
    void PlaySound()
    {
        if (audioSource != null && audioClip != null)
            audioSource.PlayOneShot(audioClip);
    }
}
