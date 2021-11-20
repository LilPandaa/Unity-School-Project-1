using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon3damage : MonoBehaviour
{

    public int damage = 150;

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy1 enemy1 = hitInfo.GetComponent<Enemy1>();
        if (enemy1 != null)
        {
            enemy1.TakeDamage(damage);
        }

        Enemy2 enemy2 = hitInfo.GetComponent<Enemy2>();
        if (enemy2 != null)
        {
            enemy2.TakeDamage(damage);
        }
    }
}

