using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadExplanationScene : MonoBehaviour
{
    //シーン移動遊び方へ飛ぶ
    public void LoadScene(string ExplanationScene)
    {
        SceneManager.LoadScene(ExplanationScene);
    }
}
