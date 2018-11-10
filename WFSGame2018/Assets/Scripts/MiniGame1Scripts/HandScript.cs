using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour {
    private Camera camera;
	// Use this for initialization
	void Start () {
        camera = Camera.main;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 mousePos;
        mousePos.x = Input.mousePosition.x;
        mousePos.y = Input.mousePosition.y;

        transform.position = camera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, camera.nearClipPlane));
    }
}
