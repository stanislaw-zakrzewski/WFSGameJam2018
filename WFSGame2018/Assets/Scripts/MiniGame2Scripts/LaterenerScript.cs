using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaterenerScript : MonoBehaviour {

    public LatarenScript lat1;
    public LatarenScript lat2;
    public LatarenScript lat3;
    public LatarenScript lat4;
    public LatarenScript lat5;
    public LatarenScript lat6;
    private List<LatarenScript> latarnie;
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
        latarnie = new List<LatarenScript>();  
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

    private int chckOn ()
    {
        int number = 0;
        foreach(LatarenScript l in latarnie)
        {
            if (l.isSwiatlo == true) number++;
        }
        return number;
    }
    private void chooseTarget()
    {
        previsLosed = losed;
        losed = rng();
        while (previsLosed == losed || latarnie[losed].isSwiatlo == true)
        {
            previsLosed = losed;
            losed = rng();
            if (chckOn() == 6) break;
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
            latarnie[losed].Zaswiec();
            chooseTarget();
            Debug.Log("Doszedł");
            cntX = nexTarget.x - transform.position.x;
            cntY = Mathf.Abs(nexTarget.y - transform.position.y);
            isDoszedl = false;
            
        }
	}
}



