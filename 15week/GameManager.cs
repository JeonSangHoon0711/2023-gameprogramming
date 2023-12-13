using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; // 씬 관리를 위한 네임스페이스를 추가합니다.

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
            timerText.text = "시간: " + seconds + "초";
            timer = 0;
        }
    }

    void GetCoin()
    {
        coinCount++;
        coinText.text = coinCount + "개";
    }

    void GameEnd()
    {
        Debug.Log("게임이 종료되었습니다");
        PlayerPrefs.SetInt("coinCount", coinCount);
        PlayerPrefs.SetInt("seconds", seconds);
        SceneManager.LoadScene("End"); // 여기에서 "EndScene"은 실제로 전환하려는 씬의 이름으로 변경해야 합니다.
    }
}