using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneScript : MonoBehaviour {

    public void loadSceneMinigame1()
    {
        SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        SceneManager.LoadScene("MiniGame1");
    }

    public void loadSceneMainMenu()
    {
        SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        SceneManager.LoadScene("MainMenu");
    }

}
