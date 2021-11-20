using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	public int maxHealth = 100;
	public static int currentHealth;
	public static bool takenDamage = false;
	public static bool invincible = false;
	public HealthBar healthBar;

	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	void Update()
	{
		if(currentHealth > 100)
		{
			currentHealth = 100;
		}

		if(currentHealth <= 0)
		{
			FindObjectOfType<GameManage>().EndGame();
			FindObjectOfType<AudioManager>().Play("PlayerDeath");

		}

		healthBar.SetHealth(currentHealth);
	}

	void OnCollisionEnter2D(Collision2D _collision)
	{
        if (_collision.gameObject.tag == "Enemy" && invincible == false)
        {
            TakeDamage(20);
			FindObjectOfType<AudioManager>().Play("PlayerHit");
        }
		else if (_collision.gameObject.tag == "Enemy" && invincible == true)
		{
			TakeDamage(0);
		}
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		takenDamage = true;
		healthBar.SetHealth(currentHealth);
	}
}


