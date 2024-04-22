using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    
    public static float CountDownTime;    // カウントダウンタイム
    
    public Text TextCountDown;              // 表示用テキストUI

    void Start()
    {
        CountDownTime = 60.0f;    // カウントダウン開始秒数をセット
    }

    void Update()
    {
        // カウントダウンタイムを表示
        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;

        if (CountDownTime < 10.0f)
        {
            TextCountDown.color= Color.red;
        }
        // 0.0秒以下になったらカウントダウンタイムを0.0で固定する
        if (CountDownTime <= 0.0f)
        {
            CountDownTime = 0.0f;
        }

    }
}
