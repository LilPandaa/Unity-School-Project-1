using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSwitch : MonoBehaviour
{
    public int powertype = 1; 
    public powerup1 Powerup1;
    public powerup2 Powerup2;
    public powerup3 Powerup3;

    // Start is called before the first frame update
    void Start()
    {
        Powerup1.enabled = true;
        Powerup2.enabled = false;
        Powerup3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("SwitchPower"))
        {
            powertype += 1;
            FindObjectOfType<AudioManager>().Play("PowerSwitch");
        }

        if (powertype > 3 || powertype == 1)
        {
            powertype = 1;
            Powerup1.enabled = true;
            Powerup2.enabled = false;
            Powerup3.enabled = false;
        } else if (powertype == 2)
        {
            Powerup1.enabled = false;
            Powerup2.enabled = true;
            Powerup3.enabled = false;
        } else if (powertype == 3)
        {
            Powerup1.enabled = false;
            Powerup2.enabled = false;
            Powerup3.enabled = true;
        }
    }
}