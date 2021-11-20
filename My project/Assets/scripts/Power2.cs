using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power2 : MonoBehaviour
{
    public static int p2;
    Text PowerItems;
    
    void Start()
    {
        PowerItems = GetComponent<Text>();
        p2 = ShopManagerScript.item2;
    }

    void Update()
    {
        PowerItems.text = "X  " + p2.ToString();
    }
}
