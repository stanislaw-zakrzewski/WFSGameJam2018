using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleFlickeringScript : MonoBehaviour {
    private Text text;
    private int counter;
    private int change = 1;
    private Random random;
    private Vector2 startingPosition;

	// Use this for initialization
	void Start () {
        random = new Random();
        text = GetComponent<Text>();
        counter = 0;
        startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(Random.value > 0.3)
        {
            text.transform.position = startingPosition + new Vector2(20 * Random.value, 10 * Random.value);
        }
        if(Random.value > 0.8)
        {
            text.color = Color.white;
        } else if(Random.value < 0.2)
        {
            text.color = Color.black;
        }
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
