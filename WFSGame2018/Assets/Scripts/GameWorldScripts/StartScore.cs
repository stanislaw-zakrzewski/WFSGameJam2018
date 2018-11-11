using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScore : MonoBehaviour {

	// Use this for initialization
	void Start () {

            PlayerPrefs.SetInt("score", 0);
            PlayerPrefs.SetInt("block1", 0);
            PlayerPrefs.SetInt("block2", 0);
            PlayerPrefs.SetInt("block3", 0);
            PlayerPrefs.SetInt("block4", 0);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
