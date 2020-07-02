using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hiteEffect;
    public int bulletDamage;
    public string enemyTag;

    private void OnCollisionEnter(Collision collision)
    {
        //creating object of effect and destroying it
        if (collision.gameObject.tag == enemyTag)
        {
            Creature enemy = collision.gameObject.GetComponent<Creature>();
            enemy.TakeDamage(bulletDamage);
        }
        Destroy(gameObject);
    }
}
