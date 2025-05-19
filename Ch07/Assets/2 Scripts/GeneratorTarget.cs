using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTarget : MonoBehaviour
{
    public GameObject targetPrefab;

    Transform[] destinations;
    void Start()
    {
        destinations = GetComponentsInChildren<Transform>(); //Transform이 자기 자신도 가져옴
    }
    
    void Update()
    {
        
    }
}
