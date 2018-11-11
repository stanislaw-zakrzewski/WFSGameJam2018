using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameWorld : MonoBehaviour {
    private loadSceneScript loadSceneScript;
    // Use this for initialization
    void Start () {
        loadSceneScript = new loadSceneScript();
        SceneManager.LoadScene("GameWorld", LoadSceneMode.Additive);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
