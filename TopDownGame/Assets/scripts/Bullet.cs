using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public bool isEnemyBullet;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(isEnemyBullet == false)
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, .4f);
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isEnemyBullet == true)
        {
            if(collision.transform.name == "Car")
            {
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(effect, .4f);
                Destroy(gameObject);
            }
        }
    }
}
