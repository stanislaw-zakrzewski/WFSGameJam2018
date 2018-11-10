using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {
    public float speed;
    public float howFastDies;
    private GameObject gameObjctToStick;
    private bool isOnTarget;
    private bool mouseIsPressed;
    private bool isMoved;
    private Rigidbody2D rb2d;
    private Rigidbody2D rb2dParent;
    private Vector2 startingPosition;
    private CharacterGeneratorScript generator;
    private HandScript handScript;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.freezeRotation = true;
	}

    public void Initialise(Vector2 startingPosition, CharacterGeneratorScript generator)
    {
        this.startingPosition = startingPosition;
        this.generator = generator;
        transform.position = startingPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("hand"))
        {
            handScript = collision.gameObject.GetComponent<HandScript>();
            if (!collision.gameObject.GetComponent<HandScript>().GetIsBusy())
            {
                handScript.SetActualCharacter(this.gameObject);
                handScript.SetIsBusy(true);
                isMoved = true;
                isOnTarget = true;
                gameObjctToStick = collision.gameObject;
                rb2dParent = gameObjctToStick.GetComponent<Rigidbody2D>();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("hand"))
        {
            if (!mouseIsPressed)
            {
                if (handScript.GetIsBusy() && handScript.GetActualCharacter().Equals(gameObject))
                {
                    isMoved = false;
                    handScript.SetIsBusy(false);
                    isOnTarget = false;
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            mouseIsPressed = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            mouseIsPressed = false;
        }
        if(!isMoved)
        {
            if (transform.position.x != startingPosition.x || transform.position.y != startingPosition.y)
            {
                Vector3 pom = new Vector3(startingPosition.x - transform.position.x, startingPosition.y - transform.position.y);
                if(Mathf.Abs(pom.x) > Mathf.Abs(pom.y))
                {
                    if(Mathf.Abs(pom.x) < 0.1)
                    {
                        transform.position = startingPosition;
                    } else
                    {
                        pom.x /= Mathf.Abs(pom.x);
                        pom.y /= Mathf.Abs(pom.x);
                        transform.position = transform.position + pom * speed * Random.value;
                    }
                } else
                {
                    if (Mathf.Abs(pom.y) < 0.1)
                    {
                        transform.position = startingPosition;
                    }
                    else
                    {
                        pom.x /= Mathf.Abs(pom.y);
                        pom.y /= Mathf.Abs(pom.y);
                        transform.position = transform.position + pom * speed * Random.value;
                    }
                }           
            }
        }
	}

    private void LateUpdate()
    {
        if (mouseIsPressed)
        {
            if (isOnTarget)
            {
                if (gameObjctToStick != null)
                {
                    rb2d.position = rb2dParent.position;
                }
            }
        }
    }

    public float GetHowFastDies()
    {
        return howFastDies;
    }

    public void Return()
    {
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
        if(handScript.GetActualCharacter() == gameObject)
        {
            handScript.SetIsBusy(false);
        }
        generator.ReturnCharater(gameObject);
        Destroy(this);
    }
}
