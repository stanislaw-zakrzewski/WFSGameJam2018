using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour {

    public GameObject gameWorldUI;

    public void HideGameWorld(bool isHided)
    {
        gameWorldUI.SetActive((!isHided));
    }


}
