using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siekiera : MonoBehaviour {

	public GameObject babsztyl;
	public GameObject zaczep;
public GameObject siek2;

public GameObject kref;
	Quaternion quat;
	Vector3 zacz;
	int hit;
	void Start () {
		kref.GetComponent<Renderer>().enabled = false;
		hit = 0;
	}
	
	void Update () {
		
		if (hit != 0) {
			transform.position = new Vector3(zaczep.transform.position.x + zacz.x, zaczep.transform.position.y + zacz.y, 0);
			transform.rotation = new Quaternion(quat.x, quat.y, quat.z, quat.w);
		}
else {
transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + Time.deltaTime );

	Vector3 a = new Vector3(zaczep.transform.position.x - transform.position.x, zaczep.transform.position.y - transform.position.y, zaczep.transform.rotation.eulerAngles.z - transform.rotation.eulerAngles.z);
	if (a.x*a.x + a.y*a.y < 1) {
		zaczepianko();
		hit++;
	}

}
	}

	public void zaczepianko() {
		zacz = new Vector3(zaczep.transform.position.x - transform.position.x, zaczep.transform.position.y - transform.position.y, zaczep.transform.rotation.eulerAngles.z - transform.rotation.eulerAngles.z);

siek2.GetComponent<Renderer>().enabled = false;
kref.GetComponent<Renderer>().enabled = true;
quat = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
//babsztyl.GetComponent<lichwiarka>().umrzyj();
	}
	
}
