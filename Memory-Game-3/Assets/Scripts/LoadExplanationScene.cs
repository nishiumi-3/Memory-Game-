using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadExplanationScene : MonoBehaviour
{
    //�V�[���ړ��V�ѕ��֔��
    public void LoadScene(string ExplanationScene)
    {
        SceneManager.LoadScene(ExplanationScene);
    }
}
