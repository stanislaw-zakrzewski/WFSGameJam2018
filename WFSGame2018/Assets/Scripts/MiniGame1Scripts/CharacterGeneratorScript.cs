using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGeneratorScript : MonoBehaviour {
    public int maxCharacterCount;
    [Space(2)]
    public GameObject character1;

    private Vector2 pos1 = new Vector2(-7.30f, 1.1f);
    private Vector2 pos2 = new Vector2(-8,3);
    private Vector2 pos3 = new Vector2(-5.4f,3.4f);
    private Vector2 pos4 = new Vector2(-2.3f,3.3f);
    private Vector2 pos5 = new Vector2(0.8f,3.5f);
    private Vector2 pos6 = new Vector2(3.7f,2.2f);
    private Vector2 pos7 = new Vector2(7.4f,1.2f);
    private Vector2 pos8 = new Vector2(7.3f,3.6f);
    private List<Vector2> positions;
    private List<GameObject> characters;
    private int score;
    private float speedUp;
    private float spawningRate;

	// Use this for initialization
	void Start () {
        positions = new List<Vector2>
        {
            pos1,
            pos2,
            pos3,
            pos4,
            pos5,
            pos6,
            pos7,
            pos8
        };
        characters = new List<GameObject>
        {
            character1
        };
        score = 0;
        speedUp = 1;
        spawningRate = 0.001f;
	}
	
	// Update is called once per frame
	void Update () {
        speedUp -= Time.deltaTime;
        if(speedUp < 0)
        {
            speedUp = 1;
            spawningRate += 0.001f;
        }
        if(Random.value < spawningRate)
        {
            GameObject pom2 = Instantiate(characters[(int)(Random.value * characters.Count - 0.01)]);
            pom2.GetComponent<CharacterScript>().Initialise(positions[(int)(Random.value * positions.Count - 0.01)], this);
            characters.Add(pom2);
        }
        if(characters.Count > 20)
        {
            //loose
        }
	}

    public void ReturnCharater(GameObject gameObject)
    {
        characters.Remove(gameObject);
    }
}
