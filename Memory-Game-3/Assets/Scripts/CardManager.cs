using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject[] cards = new GameObject[40]; //カードの表40種類を格納する配列
    public GameObject cardBack; //カードの裏を格納する変数

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        cards = cards.OrderBy(x => random.Next()).ToArray(); //配列をシャッフル

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                //カードの表の画像を4x10の形に等間隔で並べる
                GameObject cardPrefab = Instantiate(cards[i * 10 + j],
                new Vector2(j * 3, i * 4), Quaternion.identity);

                //カードの裏面を表面の子オブジェクトとして生成
                GameObject backPrefab = Instantiate(cardBack, cardPrefab.transform);

                //カードの表にBoxColliderをアタッチ
                cardPrefab.AddComponent<BoxCollider>();

                //カードの裏のローカル座標(0, 0)に設定
                backPrefab.transform.localPosition = Vector2.zero;

                //カードの裏のOrder in Layerを1に設定
                backPrefab.GetComponent<SpriteRenderer>().sortingOrder = 1; 
            }
        }
    }

  
}
