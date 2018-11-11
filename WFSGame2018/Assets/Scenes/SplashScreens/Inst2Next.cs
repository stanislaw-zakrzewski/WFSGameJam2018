using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst2Next : MonoBehaviour {

    private loadSceneScript loadSceneScript;
    void Start()
    {
        loadSceneScript = new loadSceneScript();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadSceneScript.LoadSceneMinigame2();
        }
    }
}
