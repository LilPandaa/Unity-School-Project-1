using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerup1 : MonoBehaviour
{
    public GameObject Mask;
    public GameObject fill;
    public bool maskActive;

    void Start()
    {
        Mask.SetActive(false);    
        fill.SetActive(false);
        PlayerHealth.takenDamage = false;
        maskActive = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Power1.p1 != 0 && maskActive == false)
        {
            if (Input.GetButtonDown("UsePower"))
            {
                Mask.SetActive(true);
                fill.SetActive(true);
                maskActive = true;
                Power1.p1 -= 1;
                FindObjectOfType<AudioManager>().Play("PlayerPower");
            }
        }
        else if (Power1.p1 == 0)
        {
            if (Input.GetButtonDown("UsePower"))
            {
                FindObjectOfType<AudioManager>().Play("PlayerNoPower");
            }
        }
        
        if (PlayerHealth.takenDamage == true && maskActive == true)
        {
            Mask.SetActive(false);    
            fill.SetActive(false);
            PlayerHealth.currentHealth += 20;
            PlayerHealth.takenDamage = false;
            maskActive = false;
        }
    }
}



