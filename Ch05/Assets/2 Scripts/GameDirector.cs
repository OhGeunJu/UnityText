using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hpGaue;
    
    void Start()
    {
    //    hpGaue = GameObject.Find("HP Gauge");
    }

    public void DecreaseHP()
    {
        hpGaue.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
