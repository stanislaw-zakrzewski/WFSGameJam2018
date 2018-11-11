using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lichwiarka : MonoBehaviour {

	public float speed;
	public GameObject renka;
	public float catchTime;
	public float catchCoolDown;
	private int canCatch;
	Vector2 force;

	
	private int isCatched;
	private float catchTimer;
	void Start () {
canCatch = 0;
		force = new Vector2(speed, 0);
isCatched = 0;
catchTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
        	{
			catchMe();
		}
		if (Input.GetKeyUp("space"))
        	{
			isCatched = 0;
		}

		if (transform.position.y > -10f)
			GetComponent<Rigidbody2D>().AddForce(force);
		else {
            //Scene.Unload();
            //Scene.Load();
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 10);
        }
		catchTimer += Time.deltaTime;
		if (isCatched != 0) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, (renka.transform.position.y-2f - transform.position.y)*70));
			if (catchTimer >  catchTime) {
				isCatched = 0;	
			}
		}
	}
	
	public void catchMe() {
		if (canCatch != 0 && isCatched == 0 && catchTimer > catchCoolDown) {
			catchTimer = 0;
			isCatched = 1;
		}
		
	}

	public void setCanCatch(int v) {
		canCatch = v;	
	}
	
}
