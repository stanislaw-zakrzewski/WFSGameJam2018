using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaterenerScript : MonoBehaviour {

    public GameObject lat1;
    public GameObject lat2;
    public GameObject lat3;
    public GameObject lat4;
    public GameObject lat5;
    public GameObject lat6;
    private List<GameObject> latarnie;
    private Vector3 nexTarget;
    private bool isDoszedl;
    private const float epsilon = 0.5f;

    // Use this for initialization
    void Start () {
        latarnie = new List<GameObject>();  
        latarnie.Add(lat1);
        latarnie.Add(lat2);
        latarnie.Add(lat3);
        latarnie.Add(lat4);
        latarnie.Add(lat5);
        latarnie.Add(lat6);
    }
	


    int rng ()
    {
        int num = (int)(10 * Random.value);
        int num2 = num % 6;
        num2++;
        return num2;
    }


	// Update is called once per frame
	void Update () {
	    if (isDoszedl == false)
        {
            //to idziemy do celu

            //ciekwe czy doszlismy
            if ((transform.position.x == (nexTarget.x + epsilon) || transform.position.x == (nexTarget.x - epsilon)) && (transform.position.y == (nexTarget.y + epsilon)) || (transform.position.y == (nexTarget.y - epsilon)))
            {
                isDoszedl = true;
            }
        }	
	}
}
