using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatarenScript : MonoBehaviour {

    private Vector3 position;
    public bool isSwiatlo;
    public GameObject child;
    private int cnter;
       

	// Use this for initialization
	void Start () {
        position = transform.position;
        isSwiatlo = false;
        cnter = (int)(100 * Random.value);
        Zgas();
        
    }
	
    public void Zgas() {

        child.transform.localScale = new Vector3(0, 0, 0);
        isSwiatlo = false;
    }

    public void Zaswiec()
    {
        child.transform.localScale = new Vector3(1, 1, 1);
        isSwiatlo = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isSwiatlo)
        {
            Zgas();
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
        }
        

    }

    // Update is called once per frame
    void Update () {
        //if (cnter % 54 == 0) Zgas();
        //if (cnter % 72 == 0) Zaswiec();
        //cnter++;
        
	}
}
