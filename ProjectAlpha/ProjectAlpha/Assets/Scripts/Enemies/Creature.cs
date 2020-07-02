using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public int maxHealth;
    private int currHealth;

    private void Start()
    {
        currHealth = maxHealth;
    }

    public void TakeDamage(int healthLoss)
    {
        currHealth -= healthLoss;
    }

    private void Update()
    {
        Debug.Log(currHealth);
        if (currHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
