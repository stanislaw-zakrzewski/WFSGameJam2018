using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public GameObject player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.localPosition = player.transform.position;
	}
}
