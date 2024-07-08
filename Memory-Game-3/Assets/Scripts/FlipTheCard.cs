using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class FlipTheCard : MonoBehaviour
{
    private GameObject clickedObject1, clickedObject2;
    private SpriteRenderer sprite1, sprite2;
    private int count = 0; // カードを選択している枚数を記憶するための変数
    private int clearCount = 0; // 消されたカードのペア数を記録する変数
    private int totalCards = 20; // 全てのカードの枚数（20ペア）

    public GameObject GameClearText;        //Game ClearUI
    public GameObject ExchangeButton;       //リトライボタン
    public GameObject LoadTitleButton;      //タイトルシーンへ移動するボタン

    void Start()
    {
        // 初期化時に非表示にする
        GameClearText.SetActive(false);
        ExchangeButton.SetActive(false);
        LoadTitleButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0) // カードを選択していない場合
        {
            if (Input.GetMouseButtonDown(0)) // マウス左をクリックした場合
            {
                // カメラから左クリックした座標にレイを飛ばす
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {
                    clickedObject1 = hit.collider.gameObject;
                    sprite1 = clickedObject1.GetComponent<SpriteRenderer>();
                    sprite1.sortingOrder = 2; // Order in Layerを2にする
                    Destroy(clickedObject1.GetComponent<BoxCollider>()); // 当たり判定をなくす
                    count++;
                }
            }
        }
        else if (count == 1) // カードを1枚選択している場合
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {
                    clickedObject2 = hit.collider.gameObject;
                    sprite2 = clickedObject2.GetComponent<SpriteRenderer>();
                    sprite2.sortingOrder = 2;
                    Destroy(clickedObject2.GetComponent<BoxCollider>());
                    count++;
                }
            }
        }
        else // カードを2枚選択した場合
        {
            // カードの数字が一致しているかを判定
            if (clickedObject1.name.Substring(1) == clickedObject2.name.Substring(1))
            {
                Thread.Sleep(700); // 0.7秒待機

                // 一致した場合、カードを消去
                Destroy(clickedObject1);
                Destroy(clickedObject2);
                count = 0; // カード選択の状態を0に戻す

                clearCount++; // 消されたカードのペア数を増やす
                Debug.Log(clearCount);
                // すべてのカードが消されたかをチェック
                if (clearCount == totalCards )
                {
                    GameClearText.SetActive(true);
                    ExchangeButton.SetActive(true);
                    LoadTitleButton.SetActive(true);
                    //表示
                }
            }
            else
            {
                Thread.Sleep(700); // 0.7秒待機
                clickedObject1.AddComponent<BoxCollider>(); // 当たり判定を復活させる
                clickedObject2.AddComponent<BoxCollider>();
                sprite1.sortingOrder = 0; // Order in Layerを0に戻す
                sprite2.sortingOrder = 0;
                count = 0; // カード選択の状態を0に戻す
            }
        }
    }
}
