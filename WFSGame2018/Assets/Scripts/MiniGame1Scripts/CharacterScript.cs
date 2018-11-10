﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {
    private GameObject gameObjctToStick;
    private bool isOnTarget;
    private bool mouseIsPressed;
    private Rigidbody2D rb2d;
    private Rigidbody2D rb2dParent;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.freezeRotation = true;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HandScript>())
        {
            if (!collision.gameObject.GetComponent<HandScript>().GetIsBusy())
            {

                collision.gameObject.GetComponent<HandScript>().SetActualCharacter(this.gameObject);
                collision.gameObject.GetComponent<HandScript>().SetIsBusy(true);
                isOnTarget = true;
                gameObjctToStick = collision.gameObject;
                rb2dParent = gameObjctToStick.GetComponent<Rigidbody2D>();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HandScript>())
        {
            if (!mouseIsPressed)
            {
                if (collision.gameObject.GetComponent<HandScript>().GetIsBusy() && collision.gameObject.GetComponent<HandScript>().GetActualCharacter().Equals(gameObject))
                {
                    collision.gameObject.GetComponent<HandScript>().SetIsBusy(false);
                    isOnTarget = false;
                }
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        if(Input.GetMouseButtonDown(0))
        {
            mouseIsPressed = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            mouseIsPressed = false;
        }
        
	}

    private void LateUpdate()
    {
        if (mouseIsPressed)
        {
            if (isOnTarget)
            {
                if (gameObjctToStick != null)
                {
                    rb2d.position = rb2dParent.position;
                }
            }
        }
    }
}
