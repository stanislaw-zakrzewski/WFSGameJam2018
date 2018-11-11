using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public GameObject player;
    Vector3 offset;
    public float gamespeed;
    Vector3 pom;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        pom = new Vector3(-gamespeed, 0, 0);
        this.GetComponent<Rigidbody2D>().velocity = pom;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //loose
    }
}
