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
                counter += 0.01f;// parent.gameObject.GetComponent<CharacterScript>().GetHowFastDies();
            } else
            {
                parent.GetComponent<CharacterScript>().Return();
                Destroy(parent);
                counter = 1;
            }
        } else
        {
            counter = 0;
        }
        mask.transform.localScale = new Vector2(3, counter);
        
    }

    private void LateUpdate()
    {
        mask.transform.position = new Vector2(transform.position.x, transform.position.y - (GetComponent<PolygonCollider2D>().bounds.size.y * (1-counter) / 2));
    }
}
