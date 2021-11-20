using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power3 : MonoBehaviour
{
    public static int p3;
    Text PowerItems;

    void Start()
    {
        PowerItems = GetComponent<Text>();
        p3 = ShopManagerScript.item3;
    }

    void Update()
    {
        PowerItems.text = "X  " + p3.ToString();
    }
}
