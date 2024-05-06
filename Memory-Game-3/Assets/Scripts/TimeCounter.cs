using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text counterText;
    public bool timeCounter = true;
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