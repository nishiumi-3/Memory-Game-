using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FlipTheCard : MonoBehaviour
{
    private GameObject clickedObject1, clickedObject2;
    private SpriteRenderer sprite1, sprite2;
    private int count = 0; // �J�[�h��I�����Ă��閇�����L�����邽�߂̕ϐ�

    // Update is called once per frame
    void Update()
    {
        if (count == 0) // �J�[�h��I�����Ă��Ȃ��ꍇ
        {
            if (Input.GetMouseButtonDown(0)) // �}�E�X�����N���b�N�����ꍇ
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // �J�������獶�N���b�N�������W�Ƀ��C���΂�
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {
                    clickedObject1 = hit.collider.gameObject;
                    sprite1 = clickedObject1.GetComponent<SpriteRenderer>();
                    sprite1.sortingOrder = 2; //Order in Layer��2�ɂ���
                    Destroy(clickedObject1.GetComponent<BoxCollider>()); //�����蔻����Ȃ���
                    count++;
                }
            }
        }
        else if (count == 1) //�J�[�h��1���I�����Ă���ꍇ
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
        else //�J�[�h��2���I�������ꍇ
        {
            if (clickedObject1.name.Substring(1) == clickedObject2.name.Substring(1)) //�J�[�h�̐�������v���Ă��邩�𔻒�
            {
                Thread.Sleep(500); //1�b�ҋ@

                // ��v�����ꍇ�A�J�[�h����������
                Destroy(clickedObject1);
                Destroy(clickedObject2);
                count = 0; //�J�[�h�I���̏�Ԃ�0�ɖ߂�
            }
            else
            {
                Thread.Sleep(500); //1�b�ҋ@
                clickedObject1.AddComponent<BoxCollider>(); //�����蔻��𕜊�������
                clickedObject2.AddComponent<BoxCollider>();
                sprite1.sortingOrder = 0; //Order in Layer��0�ɖ߂�
                sprite2.sortingOrder = 0;
                count = 0; //�J�[�h�I���̏�Ԃ�0�ɖ߂�
            }
        }
    }
}

