using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon3 : MonoBehaviour
{

        
    public GameObject weapon3Hitbox;
        
  // Update is called once per frame
    void Update()  
    {
        if (Input.GetButtonDown("Fire1"))
        {
            weapon3Hitbox.active = true;
            FindObjectOfType<AudioManager>().Play("Weapon3");
            StartCoroutine(Timedelay());
        }  
    }

    IEnumerator Timedelay()
    {
        yield return new WaitForSeconds(0.89f);
        weapon3Hitbox.active = false;
    }
}
