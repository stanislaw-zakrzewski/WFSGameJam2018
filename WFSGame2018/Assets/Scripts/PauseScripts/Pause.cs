using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public static bool gameIsPaused = false;
    public GameObject pauseUi;
	
    void Start()
    {
        pauseUi.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

	public void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

	}

    public void ResumeGame()
    {
        Debug.Log("RezumeGame");
        pauseUi.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void PauseGame()
    {
        pauseUi.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
