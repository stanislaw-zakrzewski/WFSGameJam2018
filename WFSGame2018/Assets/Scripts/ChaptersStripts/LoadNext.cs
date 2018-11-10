using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNext : MonoBehaviour {
    private loadSceneScript loadSceneScript;

    private void Start()
    {
        loadSceneScript = new loadSceneScript();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadSceneScript.LoadSceneMinigame1();
            
        }
    }
}
