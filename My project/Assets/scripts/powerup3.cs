using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup3 : MonoBehaviour
{
    public Animator animator;
    public GameObject Barrier;
    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Powerup3", false);
        Barrier.SetActive(false);
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Power3.p3 != 0 &&  active == false)
        {
            if (Input.GetButtonDown("UsePower"))
            {
                StartCoroutine(Activate());
                StartCoroutine(Delay());
                Power3.p3 -= 1;
                FindObjectOfType<AudioManager>().Play("PlayerPower");
            }
        }
        else if (Power3.p3 == 0)
        {
            if (Input.GetButtonDown("UsePower"))
            {
                FindObjectOfType<AudioManager>().Play("PlayerNoPower");
            }
        }
    }

    IEnumerator Activate()
    {
        animator.SetBool("Powerup3", true);
        active = true;
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("Powerup3", false);
        Debug.Log(PlayerHealth.invincible = true);
        Barrier.SetActive(true);
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5f);
        Debug.Log(PlayerHealth.invincible = false);
        Barrier.SetActive(false);
        active = false;
    }
}

