using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneScript : MonoBehaviour {

    public void loadSceneMinigame1()
    {
        
        SceneManager.LoadScene("MiniGame1");
        SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        Time.timeScale = 1f;

    }

    public void loadSceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        SceneManager.UnloadScene("Pause");
        Time.timeScale = 1f;
    }

}
