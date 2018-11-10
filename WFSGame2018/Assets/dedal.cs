using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dedal : MonoBehaviour {

	public GameObject lichwiarka;
	private int dir = 0;
	void Start () {
		dir = 0;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		GetComponent<Rigidbody2D>().AddForce(new Vector3((lichwiarka.transform.position.x-transform.position.x-1.2f)*150, 0, 0));

		if (Input.GetKeyDown("s"))
        	{
			dir --;
			
		}
		if (Input.GetKeyDown("w"))
        	{
			
			dir ++;
		}
		if (Input.GetKeyUp("w"))
        	{
			dir --;
			
		}
		if (Input.GetKeyUp("s"))
        	{
			
			dir ++;
		}


GetComponent<Rigidbody2D>().AddForce(new Vector3(0, dir*130, 0));

if (lichwiarka.transform.position.y > transform.position.y - 6) {

	lichwiarka.GetComponent<lichwiarka>().setCanCatch(1);

}
else { lichwiarka.GetComponent<lichwiarka>().setCanCatch(0);
}


	}
	
	private void OnTriggerEnter(Collider other) {
		//GetComponent<lichwiarka>().setCanCatch(1);
	}
	private void OnTriggerExit(Collider other) {
		//GetComponent<lichwiarka>().setCanCatch(0);
	}

}
