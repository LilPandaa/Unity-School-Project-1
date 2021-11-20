using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{

    public float dieTime;
    public float speed = 1000f;
    public int damage;
    public GameObject dieEffect;
    public Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = transform.right * speed;
        StartCoroutine(CountDownTimer());

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Die();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountDownTimer()
    {
        yield return new WaitForSeconds(dieTime);

        Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }

}


