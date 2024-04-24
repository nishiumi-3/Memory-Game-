using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    
    public static float CountDownTime;      // �J�E���g�_�E���^�C��
    public GameObject GameOverText;         //�Q�[���I�[�o�[UI
    public GameObject exchangeButton;       //���g���C�{�^��
    public Text TextCountDown;              // �J�E���g�_�E���̕\���p�e�L�X�gUI

    void Start()
    {
        //�ŏ��͕\�����Ȃ�
        GameOverText.SetActive(false);
        exchangeButton.SetActive(false);

        CountDownTime = 15.0f;              // �J�E���g�_�E���J�n�b�����Z�b�g�@���݂̓f�o�b�N�ϓ_����P�T�b
    }

    void Update()
    {
        // �J�E���g�_�E���^�C����\��
        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;

        //�P�O�b�؂�����F��Ԃɕς���
        if (CountDownTime < 10.0f)
        {
            TextCountDown.color = Color.red;
        }
        // 0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�AUI�n�̂̕\��
        if (CountDownTime <= 0.0f)
        {
            CountDownTime = 0.0f;
            GameOverText.SetActive(true);
            exchangeButton.SetActive(true);
        }

    }   
}
