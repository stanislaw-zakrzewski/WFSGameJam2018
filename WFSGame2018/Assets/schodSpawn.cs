using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schodSpawn : MonoBehaviour {

	public GameObject lichwiarka;
	public GameObject schod;
	private float d;
	private float length;

	private List<GameObject> schody;
	
	private int count;
	void Start () {
		schody = new List<GameObject>();
		count = 0;
		length = 20;
for (int i = 0; i < 90; i++) {
				schody.Add(Instantiate(schod, new Vector3(count*length + i-55, -10f, 0), Quaternion.identity));
				
			}

	}
	
	void Update () {
		if ( (count-1) * length <= lichwiarka.transform.position.x) {
			count ++;
d = 0; length++;
			if (count%4 == 0) {
				count++;
			}
			for (int i = 0; i < length; i++) {
				schody.Add(Instantiate(schod, new Vector3(count*length + i + 15, -10, 0), Quaternion.identity));
Destroy(schody[0]);
schody.Remove(schody[0]);
				
			}
		}	
	}
}
