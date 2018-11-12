using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneScript : MonoBehaviour{

    bool isPauseLoaded = false;
    HideUI hideUI;

    public void LoadSceneMainMenu()
    {
        
        SceneManager.LoadScene("MainMenu");
        if (isPauseLoaded)
        {
            SceneManager.UnloadSceneAsync("Pause");
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
        SceneManager.LoadScene("GameWorld", LoadSceneMode.Additive);
        Time.timeScale = 1f;

    }

    public void LoadSceneMinigame2()
    {

        SceneManager.LoadScene("MiniGame2");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;
        }
        SceneManager.LoadScene("GameWorld", LoadSceneMode.Additive);
        Time.timeScale = 1f;

    }

    public void LoadSceneMinigame3()
    {
        
        SceneManager.LoadScene("MiniGame3");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;

        }
        SceneManager.LoadScene("GameWorld", LoadSceneMode.Additive);
        Time.timeScale = 1f;

    }

    public void LoadSceneMinigame4()
    {

        SceneManager.LoadScene("MiniGame4");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;

        }
        SceneManager.LoadScene("GameWorld", LoadSceneMode.Additive);
        Time.timeScale = 1f;

    }

    public void LoadSceneChapter0()
    {
        SceneManager.LoadScene("Chapter0");
        SceneManager.UnloadSceneAsync("GameWorld");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;
        }
        Time.timeScale = 1f;
    }

    public void LoadSceneChapter1()
    {
        
        SceneManager.LoadScene("Vid1");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;
        }
        Time.timeScale = 1f;
    }

    public void LoadSceneChapter2()
    {
        SceneManager.LoadScene("Vid2");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;
        }
        Time.timeScale = 1f;
    }

    public void LoadSceneChapter3()
    {
        SceneManager.LoadScene("Vid3");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;
        }
        Time.timeScale = 1f;
    }

    public void LoadSceneChapter4()
    {
        SceneManager.LoadScene("Vid4");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;
        }
        Time.timeScale = 1f;
    }

    public void LoadSceneChapter5()
    {
        SceneManager.LoadScene("Vid5");
        if (isPauseLoaded == false)
        {
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            isPauseLoaded = true;
        }
        Time.timeScale = 1f;
    }

    public void LoadSplash1()
    {
        SceneManager.LoadScene("Instrukcja1");
    }

    public void LoadSplash2()
    {
        SceneManager.LoadScene("Instrukcja2");
    }

    public void LoadSplash3()
    {
        SceneManager.LoadScene("Instrukcja3");
    }

    public void LoadSplash4()
    {
        SceneManager.LoadScene("Instrukcja4");
    }

    void HideGameWorld(bool isHided)
    {
        hideUI.HideGameWorld(isHided);
    }

    private void Start()
    {
        hideUI = new HideUI();
    }

}
