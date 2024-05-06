using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text counterText;  //タイマーの表示用テキストUI
    public bool timeCounter = true;  //チェッカー
    public float seconds, minutes;

    void Start()
    {
        counterText = GetComponent<Text>() as Text;
    }

    void Update()
    {
        if (timeCounter)
        {
            seconds = (int)(Time.timeSinceLevelLoad % 60f);
            counterText.text = "Seconds" + ":" + seconds.ToString("00");
        }
    }

    public void endGame()
    {
        timeCounter = false;
        counterText.color = Color.yellow;
    }
}