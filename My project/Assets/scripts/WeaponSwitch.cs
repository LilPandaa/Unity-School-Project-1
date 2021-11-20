using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{   
    public Animator animator;
    public int weapontype = 1;
    Vector3 lastPos;
    public GameObject player;
    public weapon1 Weapon1;
    public weapon2 Weapon2;
    public weapon3 Weapon3;


    void FixedUpdate()
    {
        if(player.transform.position != lastPos)
        {
           Weapon1.enabled = false;
           Weapon2.enabled = false;
           Weapon3.enabled = false;
        }  else if (weapontype > 3 || weapontype == 1)
        {
            weapontype = 1;
            Weapon1.enabled = true;
            Weapon2.enabled = false;
            Weapon3.enabled = false;
            animator.SetBool("Weapon1", true);
            animator.SetBool("Weapon2", false);
            animator.SetBool("Weapon3", false);
        }   else if (weapontype == 2)
        {
            Weapon1.enabled = false;
            Weapon2.enabled = true;
            Weapon3.enabled = false;
            animator.SetBool("Weapon1", false);
            animator.SetBool("Weapon2", true);
            animator.SetBool("Weapon3", false);
        }   else 
        {
            Weapon1.enabled = false;
            Weapon2.enabled = false;
            Weapon3.enabled = true;
            animator.SetBool("Weapon1", false);
            animator.SetBool("Weapon2", false);
            animator.SetBool("Weapon3", true);
        }
        lastPos = player.transform.position;
    }

    void Update()
    {
        if (Input.GetButtonDown("SwitchWeapon"))
        {
            weapontype += 1;
            FindObjectOfType<AudioManager>().Play("WeaponSwitch");
        }
    }
}


