using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float maxSpeed;
    public float gamespeed;
    // Use this for initialization
    Rigidbody2D body;
	void Start () {
        body = this.GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

            body.velocity = new Vector2(moveX * maxSpeed, moveY * maxSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
