using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveScript : MonoBehaviour
{
    public float CountdownMinutes;        // カウントダウンタイム（分）
    public float CountdownSeconds;  　　    // カウントダウンタイム（秒）

    // Start is called before the first frame update
    void Start()
    {
        CountdownSeconds = CountdownMinutes * 60;

        GameObject mainCamera = GameObject.Find("Main Camera");
        CardManager cardManager = mainCamera.GetComponent<CardManager>();
        if (cardManager != false)
        {
            // スクリプトコンポーネントを削除
            
            Debug.Log("mainCameraについてるCardManager消しましたわ");
        }
        else
        {
            Debug.LogError("mainCameraについてるCardManager分からんかったわ");
        }

    }

    // Update is called once per frame
    void Update()
    {
        CountdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)CountdownSeconds);
        if (CountdownSeconds <= 0.0f)
        {
            // メインカメラのゲームオブジェクトを取得
            GameObject mainCamera = GameObject.Find("Main Camera");

            if (mainCamera != null)
            {
                // 削除したいスクリプトコンポーネントを取得
                CardManager cardManager = mainCamera.GetComponent<CardManager>();

                if (cardManager != false)
                {
                    // スクリプトコンポーネントを削除
                    Destroy(cardManager);
                    Debug.Log("mainCameraについてるCardManager消しましたわ");
                }
                else
                {
                    Debug.LogError("mainCameraについてるCardManager分からんかったわ");
                }
            }
            else
            {
                Debug.LogError("まずまずなんもなかったで");
            }
        }
    }
}
