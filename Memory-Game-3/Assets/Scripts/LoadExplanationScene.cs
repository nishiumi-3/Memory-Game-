using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadExplanationScene : MonoBehaviour
{
    //ƒV[ƒ“ˆÚ“®—V‚Ñ•û‚Ö”ò‚Ô
    public void LoadScene(string ExplanationScene)
    {
        SceneManager.LoadScene(ExplanationScene);
    }
}
