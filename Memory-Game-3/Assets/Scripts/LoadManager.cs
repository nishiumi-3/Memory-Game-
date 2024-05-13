using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    public void LoadTitleScene(string TitleScene)
    {
        SceneManager.LoadScene(TitleScene);
    }

    public void LoadExplanationScene(string ExplanationScene)
    {
        SceneManager.LoadScene(ExplanationScene);
    }

    public void LoadGameScene(string GameScene)
    {
        SceneManager.LoadScene(GameScene);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
