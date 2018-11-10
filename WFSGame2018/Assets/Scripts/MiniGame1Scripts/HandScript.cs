using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour {
    private Camera cam;
    private bool isBusy;
    private GameObject actualCharacter;
	// Use this for initialization
	void Start () {
        cam = Camera.main;
        name = "hand";
	}

    private void LateUpdate()
    {
        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
    }

    public bool GetIsBusy()
    {
        return isBusy;
    }

    public void SetIsBusy(bool isBusy)
    {
        this.isBusy = isBusy;
    }

    public GameObject GetActualCharacter()
    {
        return actualCharacter;
    }

    public void SetActualCharacter(GameObject actualCharacter)
    {
        this.actualCharacter = actualCharacter;
    }
}
