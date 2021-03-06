﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float maxSpeed;
    public float gamespeed;
    public int lives;
    private int invincibility;
    private float wynik;
    // Use this for initialization
    Rigidbody2D body;
    loadSceneScript loadSceneScript;
    void Start () {
        body = this.GetComponent<Rigidbody2D>();
        loadSceneScript = new loadSceneScript();
        wynik = 2;
    }
	
	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

            body.velocity = new Vector2(moveX * maxSpeed, moveY * maxSpeed);
        wynik -= Time.deltaTime;
        if(wynik < 0)
        {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
            wynik = 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (invincibility < 0) {
                lives--;
                invincibility = 100;
                if (lives < 0)
                {
                    loadSceneScript.LoadSceneChapter3();
                }
            }       
    }
    private void FixedUpdate()
    {
        invincibility--;
    }
}
