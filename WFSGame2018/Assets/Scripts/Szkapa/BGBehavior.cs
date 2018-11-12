using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGBehavior : MonoBehaviour {
    public GameObject chaty;
    public GameObject bg;
    //public GameObject player;
    private bool canICreateNewBoard;
    private Stack<GameObject> stosik;
    private float timer;
    public int numberOfChatas;
    // Use this for initialization
    void Start () {
        canICreateNewBoard = true;
        stosik = new Stack<GameObject>();
        for (int i = 0; i < numberOfChatas; i++)
        {
            Vector2 pom = new Vector2(Random.Range(-40,40),Random.Range((float)-2.5,(float) 0.5));
            Vector2 pom2 = new Vector2(transform.position.x, transform.position.y);
            stosik.Push(Instantiate(chaty,new Vector2(pom2.x-pom.x,pom.y - pom2.y),this.transform.rotation));
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x - GameObject.Find("player").transform.position.x > 10 && canICreateNewBoard)
        {
            Vector3 pom = new Vector3(transform.position.x - 80,transform.position.y,0);
            Instantiate(bg,pom,transform.rotation);
            canICreateNewBoard = false;
        }
        if (Mathf.Abs(transform.position.x - GameObject.Find("player").transform.position.x) > 100 && !canICreateNewBoard)
        {
            while(stosik.Count > 0)
            {
                Destroy(stosik.Pop().gameObject);
            }
            Destroy(this.gameObject);
        }
        timer += 1;
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
