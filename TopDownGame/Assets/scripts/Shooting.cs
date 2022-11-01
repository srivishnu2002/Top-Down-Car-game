using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public bool isEnemy;

    // Start is called before the first frame update
    void Start()
    {
        if (isEnemy == true)
        {
            InvokeRepeating("EnemyShoot", 1f, 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        

    }

    public void EnemyShoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce((GameObject.Find("Car").transform.position - transform.position) * bulletForce, ForceMode2D.Impulse);
        
    }
}
