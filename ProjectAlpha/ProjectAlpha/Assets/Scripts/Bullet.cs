using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hiteEffect;
    public int bulletDamage;

    private void OnCollisionEnter(Collision collision)
    {
        //creating object of effect and destroying it
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(bulletDamage);
        }
        Destroy(gameObject);
    }
}
