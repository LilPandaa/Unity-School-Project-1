using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerScript : MonoBehaviour
{
    public int powertype = 1; 
    public Power1 power1;
    public Power2 power2;
    public Power3 power3;
    public GameObject Mask;
    public GameObject Sanitizer;
    public GameObject Vaccine;

    // Start is called before the first frame update
    void Start()
    {
        power1.enabled = true;
        power2.enabled = false;
        power3.enabled = false;
        Mask.SetActive(true);
        Sanitizer.SetActive(false);
        Vaccine.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("SwitchPower"))
        {
            powertype += 1;
        }

        if (powertype > 3 || powertype == 1)
        {
            powertype = 1;
            power1.enabled = true;
            power2.enabled = false;
            power3.enabled = false;
            Mask.SetActive(true);
            Sanitizer.SetActive(false);
            Vaccine.SetActive(false);
        } else if (powertype == 2)
        {
            power1.enabled = false;
            power2.enabled = true;
            power3.enabled = false;
            Mask.SetActive(false);
            Sanitizer.SetActive(true);
            Vaccine.SetActive(false);
        } else if (powertype == 3)
        {
            power1.enabled = false;
            power2.enabled = false;
            power3.enabled = true;
            Mask.SetActive(false);
            Sanitizer.SetActive(false);
            Vaccine.SetActive(true);
        }
    }
}