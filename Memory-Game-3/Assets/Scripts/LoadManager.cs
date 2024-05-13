using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    //タイトルへ移動
    public void LoadTitleScene(string TitleScene)
    {
        SceneManager.LoadScene(TitleScene);
    }

    //説明文へ移動
    public void LoadExplanationScene(string ExplanationScene)
    {
        SceneManager.LoadScene(ExplanationScene);
    }

    //ゲームシーンへ移動
    public void LoadGameScene(string GameScene)
    {
        SceneManager.LoadScene(GameScene);
    }

    //ボタンを押してリトライさせる
    public void LoadSceneRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //ゲームを終了
    public void EndGame()
    {
        Application.Quit();
    }
}
