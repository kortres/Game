using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hiteEffect;

    private void OnCollisionEnter(Collision collision)
    {
        //creating object of effect and destroying it
        Destroy(gameObject);
    }
}
