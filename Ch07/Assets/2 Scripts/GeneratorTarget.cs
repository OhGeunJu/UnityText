using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTarget : MonoBehaviour
{
    public GameObject targetPrefab;

    Transform[] destinations;
    void Start()
    {
        destinations = GetComponentsInChildren<Transform>(); //Transform�� �ڱ� �ڽŵ� ������
    }
    
    void Update()
    {
        
    }
}
