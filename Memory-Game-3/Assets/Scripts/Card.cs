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
        if (Input.GetMouseButtonDown(0)) //�}�E�X���{�^�����N���b�N�����ꍇ
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //�J��������N���b�N�������W�Ƀ��C���΂�
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                clickedObject = hit.collider.gameObject;
                sprite = clickedObject.GetComponent<SpriteRenderer>();
                sprite.sortingOrder = 2 - sprite.sortingOrder; //���C�����������J�[�h�̕\�ʂ�Order in Layer�̒l��0��2�Ő؂�ւ���
            }
        }
    }
}

