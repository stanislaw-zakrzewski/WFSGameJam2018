using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWorld : MonoBehaviour {


	int score;
    public Text textScore;

    public void addScore(int dawajCoMasz)
    {
        score += dawajCoMasz;
    }

	void Start () {
        score = 0;
        textScore.text = "Score: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        //score += 1;
        textScore.text = "Score: " + score.ToString();
    }
}
