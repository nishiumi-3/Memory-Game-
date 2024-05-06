using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    
    public static float CountDownTime;      // カウントダウンタイム
    public GameObject GameOverText;         //ゲームオーバーUI
    public GameObject exchangeButton;       //リトライボタン
    public Text TextCountDown;              // カウントダウンの表示用テキストUI

    void Start()
    {
        //最初は表示しない
        GameOverText.SetActive(false);
        exchangeButton.SetActive(false);

        CountDownTime = 15.0f;              // カウントダウン開始秒数をセット　現在はデバック観点から１５秒
    }

    void Update()
    {
        // カウントダウンタイムを表示
        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;

        //１０秒切ったら色を赤に変える
        if (CountDownTime < 10.0f)
        {
            TextCountDown.color = Color.red;
        }
        // 0.0秒以下になったらカウントダウンタイムを0.0で固定、UI系のの表示
        if (CountDownTime <= 0.0f)
        {
            CountDownTime = 0.0f;
            GameOverText.SetActive(true);
            exchangeButton.SetActive(true);
        }

    }   
}
