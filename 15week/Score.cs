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
        // PlayerPrefs에서 coinCount와 seconds 값을 불러옵니다.
        int coinCount = PlayerPrefs.GetInt("coinCount", 0); // 기본값으로 0을 사용합니다.
        int seconds = PlayerPrefs.GetInt("seconds", 0); // 기본값으로 0을 사용합니다.

        // 불러온 값을 scoreboard 텍스트에 설정합니다.
        scoreboard.text = "개수: " + coinCount + "\n시간: " + seconds + "초";
    }


}