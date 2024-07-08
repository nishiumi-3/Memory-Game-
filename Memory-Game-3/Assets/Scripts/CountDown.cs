using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] GameObject CameraObj;

    [SerializeField]
    public float CountdownMinutes;   　　   // カウントダウンタイム（分）
    [SerializeField]
    public float CountdownSeconds;  　　    // カウントダウンタイム（秒）
    public GameObject GameOverText;         //ゲームオーバーUI
    public GameObject exchangeButton;       //リトライボタン
    public GameObject LoadTitleButton;      //タイトルシーンへ移動するボタン
    public Text TextCountDown;              // カウントダウンの表示用テキストUI

    void Start()
    {
        TextCountDown = GetComponent<Text>();
        CountdownSeconds = CountdownMinutes * 60;

        //最初は表示しない
        GameOverText.SetActive(false);
        exchangeButton.SetActive(false);
        LoadTitleButton.SetActive(false);

    }

    void Update()
    {
        // カウントダウンタイムを表示
        CountdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)CountdownSeconds);
        TextCountDown.text = span.ToString(@"mm\:ss");
        //１０秒切ったら色を赤に変える
        if (CountdownSeconds < 10.0f)
        {
            TextCountDown.color = Color.red;
        }
        // 0.0秒以下になったらカウントダウンタイムを0.0で固定、UI系のの表示
        if (CountdownSeconds <= 0.0f)
        {
            CountdownSeconds = 0.0f;
            GameOverText.SetActive(true);
            exchangeButton.SetActive(true);
            LoadTitleButton.SetActive(true);

            foreach (Transform n in CameraObj.transform)
            {
                GameObject.Destroy(n.gameObject);
            }
        }

    }

}
