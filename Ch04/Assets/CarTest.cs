using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    float speed = 0.02f;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        transform.Translate(this.speed, 0, 0);
        //transform.position += new Vector3(speed, 0, 0);
    }
}
