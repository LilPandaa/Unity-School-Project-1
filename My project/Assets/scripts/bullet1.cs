using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
        
    // Start is called before the first frame update
    void Start()   {
         rb.velocity = transform.right * speed;
    }
    
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
        
        Destroy(gameObject);
    }
}
