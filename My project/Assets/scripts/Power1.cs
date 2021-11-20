using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power1 : MonoBehaviour
{   
    public static int p1;
    Text PowerItems;

    void Start()
    {
        PowerItems = GetComponent<Text>();
        p1 = ShopManagerScript.item1;
    }

    void Update()
    {
        PowerItems.text = "X  " + p1.ToString();
    }
}
