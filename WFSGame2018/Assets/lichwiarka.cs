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
    private loadSceneScript loadSceneScript;
    private float wynik;

    private int isCatched;
	private float catchTimer;
	void Start () {
        canCatch = 0;
		force = new Vector2(speed, 0);
        isCatched = 0;
        catchTimer = 0;
        loadSceneScript = new loadSceneScript();
        wynik = 2;
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
            loadSceneScript.LoadSceneChapter5();
        }
		catchTimer += Time.deltaTime;
		if (isCatched != 0) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, (renka.transform.position.y-2f - transform.position.y)*70));
			if (catchTimer >  catchTime) {
				isCatched = 0;	
			}
		}
        wynik -= Time.deltaTime;
        if (wynik < 0)
        {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
            wynik = 2;
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
