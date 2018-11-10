using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGshake : MonoBehaviour {

    public float speed; //how fast it shakes
    public float amount; //how much it shakes
    public GameObject bg;

    private void Start()
    {
        speed = 1.0f;
        amount = 0.10f;
        temp = new Vector3();
    }
    Vector2 temp;
    void Update()
    {
        //bg.transform.SetPositionAndRotation(new Vector3(Mathf.Sin(Time.time * speed) * amount, Mathf.Sin(Time.time * speed) * amount, 0),new Quaternion(0,0,0,0));//= Mathf.Sin(Time.time * speed) * amount;
        temp.Set(Mathf.Sin(Time.time * speed) * amount, Mathf.Cos(Time.time * speed) * amount);
        bg.transform.position = temp;
    }
}
