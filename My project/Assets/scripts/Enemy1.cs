using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {
    
    public int health = 200;
    public float cpgiven;
    public GameObject deathEffect;

    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if(distToPlayer < agroRange)
        {
            //chase player
            ChasePlayer();
        }
        else
        {
            //stop chasing player;
            StopChasingPlayer();
        }
    }

    void ChasePlayer()
    {
        if(transform.position.x < player.position.x)
        {
            //left side of player, move right
            rb2d.velocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            //rigth side of player, move left
            rb2d.velocity = new Vector2(-moveSpeed, 0);
        }
    }

    void StopChasingPlayer()
    {
        rb2d.velocity = Vector2.zero;
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            FindObjectOfType<AudioManager>().Play("EnemyDeath");
            Die();
            PointCount.cp += cpgiven;
            
        }
    }

    void Die ()
    {
       Instantiate(deathEffect, transform.position, Quaternion.identity);
       Destroy(gameObject);
    }
}