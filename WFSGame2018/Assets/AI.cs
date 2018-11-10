using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	public float alfaFirst = 10;
	public float r = 1;
	public float speed = -3;
	public float range = 30;
	public float initialRot = 0;
	Vector3 temp;
	Quaternion rot;

	private float alfa;
	void Start () {
		alfa = alfaFirst;
		temp = new Vector3(0.01f, 0, 0);
		Quaternion rot = new Quaternion();
	}
	
	void FixedUpdate () {
		alfa += Time.deltaTime*speed;
		temp.Set(Mathf.Cos(alfa)*r, Mathf.Sin(alfa)*r, 0);
		transform.localPosition = temp;
		transform.eulerAngles = new Vector3(0, 0, Mathf.Cos(alfa)*range + initialRot );
	}
}
