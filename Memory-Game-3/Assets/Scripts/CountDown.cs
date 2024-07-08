using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] GameObject CameraObj;

    [SerializeField]
    public float CountdownMinutes;   �@�@   // �J�E���g�_�E���^�C���i���j
    [SerializeField]
    public float CountdownSeconds;  �@�@    // �J�E���g�_�E���^�C���i�b�j
    public GameObject GameOverText;         //�Q�[���I�[�o�[UI
    public GameObject exchangeButton;       //���g���C�{�^��
    public GameObject LoadTitleButton;      //�^�C�g���V�[���ֈړ�����{�^��
    public Text TextCountDown;              // �J�E���g�_�E���̕\���p�e�L�X�gUI

    void Start()
    {
        TextCountDown = GetComponent<Text>();
        CountdownSeconds = CountdownMinutes * 60;

        //�ŏ��͕\�����Ȃ�
        GameOverText.SetActive(false);
        exchangeButton.SetActive(false);
        LoadTitleButton.SetActive(false);

    }

    void Update()
    {
        // �J�E���g�_�E���^�C����\��
        CountdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)CountdownSeconds);
        TextCountDown.text = span.ToString(@"mm\:ss");
        //�P�O�b�؂�����F��Ԃɕς���
        if (CountdownSeconds < 10.0f)
        {
            TextCountDown.color = Color.red;
        }
        // 0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�AUI�n�̂̕\��
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
