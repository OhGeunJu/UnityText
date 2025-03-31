using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speedRatio = 0.01f;
    public float stopSpeed = 0.04f;
    public float decreaseRate = 0.98f;
    float speed = 0f;
    Vector2 startPos;
    Vector2 endPos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength * speedRatio / 10000.0f;
        }

        transform.Translate(this.speed, 0, 0);
        //transform.position += new Vector3(speed, 0, 0);
        //transform.rotation *= Quaternion.Euler(0,0,speed);

        this.speed *= decreaseRate;

        if(speed < stopSpeed)
        {
            this.speed = 0f;
        }
    }
}
