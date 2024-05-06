using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour
{
    //ƒV[ƒ“ˆÚ“®ƒQ[ƒ€‰æ–Ê‚Ö”ò‚Ô
    public void LoadScene(string GameScene)
    {
        SceneManager.LoadScene(GameScene);
    }
}
