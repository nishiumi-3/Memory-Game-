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
        // CountDownスクリプトを持つオブジェクトを検索して取得
        countDownScript = FindObjectOfType<CountDown>();
        // CardManagerスクリプトをアタッチしたGameObjectからCardManagerスクリプトを取得
        cardManager = FindObjectOfType<CardManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //エスケープキーが押されたらタイトルへ
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScene");
        }

        //Rキーを押したらリトライ
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // Zキーが押されたとき
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // CountdownMinutesに3を追加
            if (countDownScript != null)
            {
                countDownScript.CountdownMinutes += 3;
                // CountdownSecondsを再計算して反映
                countDownScript.CountdownSeconds = countDownScript.CountdownMinutes * 60;
            }
        }

        // Fキーが押されたとき
        if (Input.GetKeyDown(KeyCode.F))
        {
            // すべてのbackPrefabのローカル座標を変更
            foreach (GameObject backPrefab in cardManager.backPrefabs)
            {
                backPrefab.transform.localPosition = new Vector2(50, -1);
            }
            Debug.Log("Changed all backPrefab localPositions to (50, -1)");
        }
    }
}

//backPrefab.transform.localPosition = new Vector2(50, -1);