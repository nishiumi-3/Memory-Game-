using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour
{
    //シーン移動ゲーム画面へ飛ぶ
    public void LoadScene(string GameScene)
    {
        SceneManager.LoadScene(GameScene);
    }
}
