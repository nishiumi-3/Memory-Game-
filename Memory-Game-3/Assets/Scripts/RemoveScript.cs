using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveScript : MonoBehaviour
{
    public float CountdownMinutes;        // �J�E���g�_�E���^�C���i���j
    public float CountdownSeconds;  �@�@    // �J�E���g�_�E���^�C���i�b�j

    // Start is called before the first frame update
    void Start()
    {
        CountdownSeconds = CountdownMinutes * 60;

        GameObject mainCamera = GameObject.Find("Main Camera");
        CardManager cardManager = mainCamera.GetComponent<CardManager>();
        if (cardManager != false)
        {
            // �X�N���v�g�R���|�[�l���g���폜
            
            Debug.Log("mainCamera�ɂ��Ă�CardManager�����܂�����");
        }
        else
        {
            Debug.LogError("mainCamera�ɂ��Ă�CardManager������񂩂�����");
        }

    }

    // Update is called once per frame
    void Update()
    {
        CountdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)CountdownSeconds);
        if (CountdownSeconds <= 0.0f)
        {
            // ���C���J�����̃Q�[���I�u�W�F�N�g���擾
            GameObject mainCamera = GameObject.Find("Main Camera");

            if (mainCamera != null)
            {
                // �폜�������X�N���v�g�R���|�[�l���g���擾
                CardManager cardManager = mainCamera.GetComponent<CardManager>();

                if (cardManager != false)
                {
                    // �X�N���v�g�R���|�[�l���g���폜
                    Destroy(cardManager);
                    Debug.Log("mainCamera�ɂ��Ă�CardManager�����܂�����");
                }
                else
                {
                    Debug.LogError("mainCamera�ɂ��Ă�CardManager������񂩂�����");
                }
            }
            else
            {
                Debug.LogError("�܂��܂��Ȃ���Ȃ�������");
            }
        }
    }
}
