using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    private loadSceneScript loadSceneScript;
    //KurwaJakisZartZmiennaGlobalnaXD xd;

    private Text score;
    int game1EndScore = 10;
    int game2EndScore = 10;
    int game3EndScore = 10;
    int game4EndScore = 10;
    int globalScore;

    


    void Start () {
        score = GetComponent<Text>();
        globalScore = 0;
        //xd = new KurwaJakisZartZmiennaGlobalnaXD();
        score.text = PlayerPrefs.GetInt("score").ToString();
        loadSceneScript = new loadSceneScript();
	}

	// Update is called once per frame
	void Update () {
        globalScore = PlayerPrefs.GetInt("score");
        Debug.Log(globalScore + "  " + PlayerPrefs.GetInt("score"));
        score.text = globalScore.ToString();

        /*if(globalScore == game1EndScore && PlayerPrefs.GetInt("block1") == 0)
        {
            PlayerPrefs.SetInt("block1", 1);
            loadSceneScript.LoadSceneChapter2();
        }
        else if(globalScore == (game1EndScore + game2EndScore) && PlayerPrefs.GetInt("block2") == 0)
        {
            PlayerPrefs.SetInt("block2", 1);
            loadSceneScript.LoadSceneChapter3();
        }
        else if (globalScore == (game1EndScore + game2EndScore + game3EndScore) && PlayerPrefs.GetInt("block3") == 0)
        {
            PlayerPrefs.SetInt("block3", 1);
            loadSceneScript.LoadSceneChapter4();
        }
        else if (globalScore == (game1EndScore + game2EndScore + game3EndScore + game4EndScore) && PlayerPrefs.GetInt("block4") == 0)
        {
            PlayerPrefs.SetInt("block4", 1);

            loadSceneScript.LoadSceneChapter5();
        }*/
       

    }
}