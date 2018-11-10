using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkScript : MonoBehaviour {
    public GameObject parent;
    public GameObject mask;
    private float counter;
    private bool isOnWater;
	// Use this for initialization
	void Start () {
        transform.SetParent(parent.transform);
        mask.transform.SetParent(parent.transform);
        counter = 0.0f;
        mask.transform.localScale = new Vector2(0, 0);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<RiverScript>())
        {
            isOnWater = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<RiverScript>())
        {
            isOnWater = false;
        }
    }

    // Update is called once per frame
    void Update () {
        if (isOnWater)
        {
            if(counter < 1)
            {
                Debug.Log(counter);
                counter += 0.01f;
            } else
            {
                counter = 1;
            }
        } else
        {
            counter = 0;
        }
        mask.transform.position =  new Vector2(mask.transform.position.x, 0 - mask.transform.localScale.y / 2);
        mask.transform.localScale = new Vector2(1, counter);
    }
}
