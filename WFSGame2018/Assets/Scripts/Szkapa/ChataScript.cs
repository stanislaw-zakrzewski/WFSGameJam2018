using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChataScript : MonoBehaviour {

    public GameObject player;
    public GameObject projectile;
    private Vector2 position;
    private Vector2 pom;
    private Random rng;
    public float power;
    private ArrayList pebles;
    Vector2 tempv;
    Vector2 dystance;
    float counter = 0;
    private float realdystance;



    // Use this for initialization
    void Start () {
        rng = new Random();
        position = this.transform.position;
        counter = Random.Range(0,45);
        
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(player.GetInstanceID());
        dystance = new Vector2(Mathf.Abs(GameObject.Find("player").GetComponent<Rigidbody2D>().position.x - transform.position.x),
                Mathf.Abs( GameObject.Find("player").GetComponent<Rigidbody2D>().position.y - transform.position.y));
        realdystance = Mathf.Sqrt(Mathf.Pow(dystance.x,2) + Mathf.Pow(dystance.y,2));
        if (counter > 60 && (realdystance < 9))
        {

            GameObject temp = Instantiate(projectile, position, transform.rotation);
            
            //pebles.Add(temp);
            tempv = new Vector2(GameObject.Find("player").GetComponent<Rigidbody2D>().position.x - temp.GetComponent<Rigidbody2D>().position.x, GameObject.Find("player").GetComponent<Rigidbody2D>().position.y - temp.GetComponent<Rigidbody2D>().position.y);

            tempv = tempv * power;
            temp.GetComponent<Rigidbody2D>().velocity = tempv;
            counter = 0;
        }
        counter += 1;
    }
    void Shoot()
    {
        
    }
    void Aim()
    {
        //position = player.transform.position;// + new pom();

    }
}
