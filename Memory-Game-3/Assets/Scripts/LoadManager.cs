using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    //�^�C�g���ֈړ�
    public void LoadTitleScene(string TitleScene)
    {
        SceneManager.LoadScene(TitleScene);
    }

    //�������ֈړ�
    public void LoadExplanationScene(string ExplanationScene)
    {
        SceneManager.LoadScene(ExplanationScene);
    }

    //�Q�[���V�[���ֈړ�
    public void LoadGameScene(string GameScene)
    {
        SceneManager.LoadScene(GameScene);
    }

    //�{�^���������ă��g���C������
    public void LoadSceneRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //�Q�[�����I��
    public void EndGame()
    {
        Application.Quit();
    }
}
