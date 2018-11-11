using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutScript : MonoBehaviour {

    public Vector2 v2;
    public GameObject dupa;
    private Camera cam;
    int cnter;
	// Use this for initialization
	void Start () {
        cnter = 0;
        cam = Camera.main;
	}

    public float speed = 1.5f;
    private Vector3 target;
    private GameObject tmp;

	// Update is called once per frame
	void Update () {
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 tmp2 = new Vector2(0, -5); 
            tmp = Instantiate(dupa, tmp2, Quaternion.identity) as GameObject;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float projectileX = mousePosition.x - tmp2.x;
            float projectileY = mousePosition.y - tmp2.y;
            float r = Mathf.Sqrt(projectileX * projectileX + projectileY * projectileY);
            Vector2 projectileThrow = new Vector2(projectileX / r, projectileY / r);
            tmp.GetComponent<Rigidbody2D>().AddForce(projectileThrow * 1000);
        }

        

    }
}
