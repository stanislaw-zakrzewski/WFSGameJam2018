using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneScript : MonoBehaviour {

    bool isPauseLoaded = false;

    public void LoadSceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        if (isPauseLoaded)
        {
            SceneManager.UnloadScene("Pause");
            isPauseLoaded = false;
        }

        Time.timeScale = 1f;
    }

    public void LoadSceneMinigame1()
    {

        SceneManager.LoadScene("MiniGame1");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;
        }
        Time.timeScale = 1f;

    }

    public void LoadSceneChapter0()
    {
        SceneManager.LoadScene("Chapter0");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;
        }
        Time.timeScale = 1f;
    }
}
