using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    private Text score;
	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
        PlayerPrefs.SetInt("score", 0);
        score.text = PlayerPrefs.GetInt("score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
        score.text = PlayerPrefs.GetInt("score").ToString();
    }
}
