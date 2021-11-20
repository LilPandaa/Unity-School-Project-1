using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[4,4];
    public static float cpo;
    public static int item1;
    public static int item2;
    public static int item3;
    public Text CpTxt;

    void Start()
    {
        CpTxt.text = "Covid   Points:  " + cpo.ToString();

        //ID's
        shopItems[1,1] = 1;
        shopItems[1,2] = 2;
        shopItems[1,3] = 3;

        //Price
        shopItems[2,1] = 10;
        shopItems[2,2] = 20;
        shopItems[2,3] = 30;

        //Quantity
        shopItems[3,1] = 0;
        shopItems[3,2] = 0;
        shopItems[3,3] = 0;

    }


    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(cpo >= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            cpo -= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3,ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CpTxt.text = "Covid Points:" + cpo.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3,ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();

        }
    }

    void Update()
    {
        if (shopItems[3,1] != 0)
        {     
            item1 = shopItems[3,1];
        }
        if (shopItems[3,2] != 0)
        {
            item2 = shopItems[3,2];
        }
        if (shopItems[3,3] != 0)
        {
            item3 = shopItems[3,3];
        }
    }
}
