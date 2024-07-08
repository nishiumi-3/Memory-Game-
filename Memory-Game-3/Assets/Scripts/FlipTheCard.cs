using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class FlipTheCard : MonoBehaviour
{
    private GameObject clickedObject1, clickedObject2;
    private SpriteRenderer sprite1, sprite2;
    private int count = 0; // �J�[�h��I�����Ă��閇�����L�����邽�߂̕ϐ�
    private int clearCount = 0; // �����ꂽ�J�[�h�̃y�A�����L�^����ϐ�
    private int totalCards = 20; // �S�ẴJ�[�h�̖����i20�y�A�j

    public GameObject GameClearText;        //Game ClearUI
    public GameObject ExchangeButton;       //���g���C�{�^��
    public GameObject LoadTitleButton;      //�^�C�g���V�[���ֈړ�����{�^��

    void Start()
    {
        // ���������ɔ�\���ɂ���
        GameClearText.SetActive(false);
        ExchangeButton.SetActive(false);
        LoadTitleButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0) // �J�[�h��I�����Ă��Ȃ��ꍇ
        {
            if (Input.GetMouseButtonDown(0)) // �}�E�X�����N���b�N�����ꍇ
            {
                // �J�������獶�N���b�N�������W�Ƀ��C���΂�
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {
                    clickedObject1 = hit.collider.gameObject;
                    sprite1 = clickedObject1.GetComponent<SpriteRenderer>();
                    sprite1.sortingOrder = 2; // Order in Layer��2�ɂ���
                    Destroy(clickedObject1.GetComponent<BoxCollider>()); // �����蔻����Ȃ���
                    count++;
                }
            }
        }
        else if (count == 1) // �J�[�h��1���I�����Ă���ꍇ
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
        else // �J�[�h��2���I�������ꍇ
        {
            // �J�[�h�̐�������v���Ă��邩�𔻒�
            if (clickedObject1.name.Substring(1) == clickedObject2.name.Substring(1))
            {
                Thread.Sleep(700); // 0.7�b�ҋ@

                // ��v�����ꍇ�A�J�[�h������
                Destroy(clickedObject1);
                Destroy(clickedObject2);
                count = 0; // �J�[�h�I���̏�Ԃ�0�ɖ߂�

                clearCount++; // �����ꂽ�J�[�h�̃y�A���𑝂₷
                Debug.Log(clearCount);
                // ���ׂẴJ�[�h�������ꂽ�����`�F�b�N
                if (clearCount == totalCards )
                {
                    GameClearText.SetActive(true);
                    ExchangeButton.SetActive(true);
                    LoadTitleButton.SetActive(true);
                    //�\��
                }
            }
            else
            {
                Thread.Sleep(700); // 0.7�b�ҋ@
                clickedObject1.AddComponent<BoxCollider>(); // �����蔻��𕜊�������
                clickedObject2.AddComponent<BoxCollider>();
                sprite1.sortingOrder = 0; // Order in Layer��0�ɖ߂�
                sprite2.sortingOrder = 0;
                count = 0; // �J�[�h�I���̏�Ԃ�0�ɖ߂�
            }
        }
    }
}
