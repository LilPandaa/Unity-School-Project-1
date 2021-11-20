using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
{   
    public static float cp;
    Text CovidPoint;


    void Start()
    {
        CovidPoint = GetComponent<Text>();
        cp = ShopManagerScript.cpo;
    }

    void Update()
    {
        CovidPoint.text = "Covid   Points:  " + cp.ToString();
        ShopManagerScript.cpo = cp;
    }
}
