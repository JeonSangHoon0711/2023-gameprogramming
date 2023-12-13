using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; // �� ������ ���� ���ӽ����̽��� �߰��մϴ�.

public class GameManager : MonoBehaviour
{
    public static int coinCount = 0;
    private float timer = 0.0f;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI coinText;
    public static int seconds = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            seconds++;
            timerText.text = "�ð�: " + seconds + "��";
            timer = 0;
        }
    }

    void GetCoin()
    {
        coinCount++;
        coinText.text = coinCount + "��";
    }

    void GameEnd()
    {
        Debug.Log("������ ����Ǿ����ϴ�");
        PlayerPrefs.SetInt("coinCount", coinCount);
        PlayerPrefs.SetInt("seconds", seconds);
        SceneManager.LoadScene("End"); // ���⿡�� "EndScene"�� ������ ��ȯ�Ϸ��� ���� �̸����� �����ؾ� �մϴ�.
    }
}