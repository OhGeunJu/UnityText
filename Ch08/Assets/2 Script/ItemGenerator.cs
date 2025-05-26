using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        delta += Time.deltaTime;

        if(delta > span)
        {
            delta = 0;
            Instantiate(applePrefab);
        }
    }
}
