using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour
{
    //�V�[���ړ��Q�[����ʂ֔��
    public void LoadScene(string GameScene)
    {
        SceneManager.LoadScene(GameScene);
    }
}
