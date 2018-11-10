using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleFlickeringScript : MonoBehaviour {
    private Text text;
    private int counter;
    private int change = 1;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        counter += change;
        if(counter > 20)
        {
            change = -1;
            text.text = "Pozytywizm";
        }
        if(counter < 0)
        {
            change = 1;
            text.text = "Negatywizm";
        }
	}
}
