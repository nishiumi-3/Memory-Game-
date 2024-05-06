using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private GameObject clickedObject;
    private SpriteRenderer sprite;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //マウス左ボタンをクリックした場合
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //カメラからクリックした座標にレイを飛ばす
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                clickedObject = hit.collider.gameObject;
                sprite = clickedObject.GetComponent<SpriteRenderer>();
                sprite.sortingOrder = 2 - sprite.sortingOrder; //レイが当たったカードの表面のOrder in Layerの値を0と2で切り替える
            }
        }
    }
}

