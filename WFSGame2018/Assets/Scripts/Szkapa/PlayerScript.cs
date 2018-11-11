using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float maxSpeed;
    public float gamespeed;
    public int lives;
    public float invincibility;
    // Use this for initialization
    Rigidbody2D body;
	void Start () {
        body = this.GetComponent<Rigidbody2D>();
        lives = 5;
        invincibility = 0;
    }
	
	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

            body.velocity = new Vector2(moveX * maxSpeed, moveY * maxSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (invincibility <= 0) {
            lives--;
            invincibility = 2;
            if (lives < 0)
            {
                //loose
            }
        } else
        {
            invincibility -= Time.deltaTime;
        }
    }
}
