using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShortcutKeys : MonoBehaviour
{
    private CountDown countDownScript;
    private CardManager cardManager; 

    void Start()
    {
        // CountDown�X�N���v�g�����I�u�W�F�N�g���������Ď擾
        countDownScript = FindObjectOfType<CountDown>();
        // CardManager�X�N���v�g���A�^�b�`����GameObject����CardManager�X�N���v�g���擾
        cardManager = FindObjectOfType<CardManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //�G�X�P�[�v�L�[�������ꂽ��^�C�g����
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScene");
        }

        //R�L�[���������烊�g���C
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // Z�L�[�������ꂽ�Ƃ�
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // CountdownMinutes��3��ǉ�
            if (countDownScript != null)
            {
                countDownScript.CountdownMinutes += 3;
                // CountdownSeconds���Čv�Z���Ĕ��f
                countDownScript.CountdownSeconds = countDownScript.CountdownMinutes * 60;
            }
        }

        // F�L�[�������ꂽ�Ƃ�
        if (Input.GetKeyDown(KeyCode.F))
        {
            // ���ׂĂ�backPrefab�̃��[�J�����W��ύX
            foreach (GameObject backPrefab in cardManager.backPrefabs)
            {
                backPrefab.transform.localPosition = new Vector2(50, -1);
            }
            Debug.Log("Changed all backPrefab localPositions to (50, -1)");
        }
    }
}

//backPrefab.transform.localPosition = new Vector2(50, -1);