using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    
    public static float CountDownTime;    // �J�E���g�_�E���^�C��
    
    public Text TextCountDown;              // �\���p�e�L�X�gUI

    void Start()
    {
        CountDownTime = 60.0f;    // �J�E���g�_�E���J�n�b�����Z�b�g
    }

    void Update()
    {
        // �J�E���g�_�E���^�C����\��
        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;

        if (CountDownTime < 10.0f)
        {
            TextCountDown.color= Color.red;
        }
        // 0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ肷��
        if (CountDownTime <= 0.0f)
        {
            CountDownTime = 0.0f;
        }

    }
}
