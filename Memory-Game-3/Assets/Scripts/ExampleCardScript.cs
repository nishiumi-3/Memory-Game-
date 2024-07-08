using UnityEngine;

public class ExampleCardScript : MonoBehaviour
{
    public Sprite cardFront; // 表向きの画像
    public Sprite cardBack; // 裏向きの画像
    private SpriteRenderer spriteRenderer;
    private bool isFlipped = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRendererコンポーネントが見つかりません！");
            return;
        }
        cardBack = spriteRenderer.sprite; // 初期画像を裏向きの画像とする
    }

    void OnMouseDown()
    {
        if (spriteRenderer != null)
        {
            if (isFlipped)
            {
                spriteRenderer.sprite = cardBack; // 裏向きに戻す
            }
            else
            {
                spriteRenderer.sprite = cardFront; // 表向きにする
            }
            isFlipped = !isFlipped; // 状態を反転させる
        }
    }
}

