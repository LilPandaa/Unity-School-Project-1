using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup2 : MonoBehaviour
{
    
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Powerup2", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Power2.p2 != 0)
        {
            if (Input.GetButtonDown("UsePower"))
            {
                PlayerHealth.currentHealth += 60;
                StartCoroutine(Activate());
                Power2.p2 -= 1;
                FindObjectOfType<AudioManager>().Play("PlayerPower");
            }
        }
        else if (Power2.p2 == 0)
        {
            if (Input.GetButtonDown("UsePower"))
            {
                FindObjectOfType<AudioManager>().Play("PlayerNoPower");
            }
        }
    }

    IEnumerator Activate()
    {
        animator.SetBool("Powerup2", true);
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("Powerup2", false);
    }
}

