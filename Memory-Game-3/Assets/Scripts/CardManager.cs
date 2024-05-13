using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject[] cards = new GameObject[52]; //�J�[�h�̕\52��ނ��i�[����z��
    public GameObject cardBack; //�J�[�h�̗����i�[����ϐ�

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        cards = cards.OrderBy(x => random.Next()).ToArray(); //�z����V���b�t������

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                //�J�[�h�̕\�̉摜��4x13�̌`�ɓ��Ԋu�ŕ��ׂ�
                GameObject cardPrefab = Instantiate(cards[i * 13 + j],
                new Vector2(j * 3, i * 4), Quaternion.identity);

                //�J�[�h�̗��ʂ�\�ʂ̎q�I�u�W�F�N�g�Ƃ��Đ�������
                GameObject backPrefab = Instantiate(cardBack, cardPrefab.transform);

                //�J�[�h�̕\�ɂ�BoxCollider���A�^�b�`����
                cardPrefab.AddComponent<BoxCollider>();

                //�J�[�h�̗��̃��[�J�����W��(0, 0)�ɐݒ肷��
                backPrefab.transform.localPosition = Vector2.zero;

                //�J�[�h�̗���Order in Layer��1�ɐݒ肷��
                backPrefab.GetComponent<SpriteRenderer>().sortingOrder = 1; 
            }
        }
    }

  
}