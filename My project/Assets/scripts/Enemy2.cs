using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public int health = 200;
    public int shootSpeed;
    public int timeBetweenShots = 50;
    public GameObject deathEffect;

    private bool canShoot;
    private bool m_FacingRight = true;

    public GameObject bullete;

    [SerializeField]
    Transform player;

    [SerializeField]
    Transform shootPos;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        canShoot = true;
    }

    void Update()
    {
        // distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if(distToPlayer < agroRange)
        {
            if (player.position.x > transform.position.x && !m_FacingRight)
            {
                Flip();
            }
            else if (player.position.x < transform.position.x && m_FacingRight) 
            {
                Flip();
            }



            rb2d.velocity = Vector2.zero;

            if(canShoot == true)
            {
            StartCoroutine(Shoot());
            }
        }
    }


	private void Flip()
	{
		// Switch the way the player is labelled as facing.
		m_FacingRight = !m_FacingRight;

		transform.Rotate (0f, 180f, 0f);
	}


    IEnumerator Shoot()
    {
        canShoot = false;

        yield return new WaitForSeconds(timeBetweenShots);
        GameObject newBullet = Instantiate(bullete, shootPos.position, transform.rotation);

        canShoot = true;
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            FindObjectOfType<AudioManager>().Play("EnemyDeath");
            Die();
            PointCount.cp += 5;
        }
    }

    void Die ()
    {
       Instantiate(deathEffect, transform.position, Quaternion.identity);
       Destroy(gameObject);
    }
}
