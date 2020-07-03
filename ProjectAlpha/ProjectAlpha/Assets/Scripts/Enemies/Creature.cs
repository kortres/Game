using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public int maxHealth;
    public string enemyTag;
    public int contactDamage;
    public float damageDelay;

    private int currHealth;
    private bool invinsible = false;
    private float inTimer;

    private void Start()
    {
        currHealth = maxHealth;
    }

    public void TakeDamage(int healthLoss)
    {
        if (!invinsible)
        {
            currHealth -= healthLoss;
            if (damageDelay > 0)
            {
                invinsible = true;
            }
        }
    }

    private void Update()
    {
        //Debug.Log(currHealth);
        if (currHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void CheckInvinsible()
    {
        if (invinsible)
        {
            Debug.Log(inTimer);
            inTimer += Time.fixedDeltaTime;
            if (inTimer >= damageDelay)
            {
                invinsible = false;
                inTimer = 0f;
            }
        }
    }

    private void FixedUpdate()
    {
        CheckInvinsible();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == enemyTag)
        {
            Creature cr = collision.gameObject.GetComponent<Creature>();
            TakeDamage(cr.contactDamage);
        }
    }
}
