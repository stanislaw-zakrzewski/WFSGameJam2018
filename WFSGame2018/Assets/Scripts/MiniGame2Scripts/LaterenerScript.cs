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
    private const float epsilon = 0.2f;
    private float movment = 0.1f;
    float cntX = 0;
    float cntY = 0;
    int losed = -1;
    int previsLosed = -1;

    // Use this for initialization
    void Start () {
        latarnie = new List<GameObject>();  
        latarnie.Add(lat1);
        latarnie.Add(lat2);
        latarnie.Add(lat3);
        latarnie.Add(lat4);
        latarnie.Add(lat5);
        latarnie.Add(lat6);
        isDoszedl = false;
        chooseTarget();
        cntX = (nexTarget.x - transform.position.x);
        cntY = Mathf.Abs(nexTarget.y - transform.position.y);
    }
	


    private int rng ()
    {
        int num = (int)(10 * Random.value);
        int num2 = num % 6;
        //num2++;
        return num2;
    }

    private void chooseTarget()
    {
        previsLosed = losed;
        losed = rng();
        while (previsLosed == losed)
        {
            previsLosed = losed;
            losed = rng();
        }
        nexTarget = latarnie[losed].transform.position;
        Debug.Log(losed);
        
    }

    

    // Update is called once per frame
    void Update() {
        if (isDoszedl == false)
        {
            if (transform.position.x != nexTarget.x || transform.position.y != nexTarget.y)
            {
                Vector3 pom = new Vector3(nexTarget.x - transform.position.x, nexTarget.y - transform.position.y);
                if (Mathf.Abs(pom.x) > Mathf.Abs(pom.y))
                {
                    if (Mathf.Abs(pom.x) < 0.1)
                    {
                        transform.position = nexTarget;
                        isDoszedl = true;
                    }
                    else
                    {
                        pom.x /= Mathf.Abs(pom.x);
                        pom.y /= Mathf.Abs(pom.x);
                        transform.position = transform.position + pom * movment;
                    }
                }
                else
                {
                    if (Mathf.Abs(pom.y) < 0.1)
                    {
                        transform.position = nexTarget;
                        isDoszedl = true;
                    }
                    else
                    {
                        pom.x /= Mathf.Abs(pom.y);
                        pom.y /= Mathf.Abs(pom.y);
                        transform.position = transform.position + pom * movment;
                    }
                }
            }
        }
        else
        {
            chooseTarget();
            Debug.Log("Doszedł");
            cntX = nexTarget.x - transform.position.x;
            cntY = Mathf.Abs(nexTarget.y - transform.position.y);
            isDoszedl = false;
        }
	}
}



