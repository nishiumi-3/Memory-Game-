using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadExplanationScene : MonoBehaviour
{
    public void LoadScene(string ExplanationScene)
    {
        SceneManager.LoadScene(ExplanationScene);
    }
}
