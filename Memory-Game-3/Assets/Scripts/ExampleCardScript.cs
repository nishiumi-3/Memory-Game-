using UnityEngine;

public class ExampleCardScript : MonoBehaviour
{
    public Sprite cardFront; // �\�����̉摜
    public Sprite cardBack; // �������̉摜
    private SpriteRenderer spriteRenderer;
    private bool isFlipped = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer�R���|�[�l���g��������܂���I");
            return;
        }
        cardBack = spriteRenderer.sprite; // �����摜�𗠌����̉摜�Ƃ���
    }

    void OnMouseDown()
    {
        if (spriteRenderer != null)
        {
            if (isFlipped)
            {
                spriteRenderer.sprite = cardBack; // �������ɖ߂�
            }
            else
            {
                spriteRenderer.sprite = cardFront; // �\�����ɂ���
            }
            isFlipped = !isFlipped; // ��Ԃ𔽓]������
        }
    }
}

