using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs���� coinCount�� seconds ���� �ҷ��ɴϴ�.
        int coinCount = PlayerPrefs.GetInt("coinCount", 0); // �⺻������ 0�� ����մϴ�.
        int seconds = PlayerPrefs.GetInt("seconds", 0); // �⺻������ 0�� ����մϴ�.

        // �ҷ��� ���� scoreboard �ؽ�Ʈ�� �����մϴ�.
        scoreboard.text = "����: " + coinCount + "\n�ð�: " + seconds + "��";
    }


}