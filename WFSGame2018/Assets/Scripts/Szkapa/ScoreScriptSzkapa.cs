using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScriptSzkapa : MonoBehaviour {
    Text text;
    int lives;
    GameObject player;


	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {

        lives = player.GetComponent<PlayerScript>().lives;

        text.text = "Lives : " + lives;
	}
}
