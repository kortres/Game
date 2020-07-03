using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firepoint;
    private EnemyAI ai;

    public float bulletForce;
    public float shootingPeriod;
    private float currTime;

    private void Start()
    {
       ai = GetComponent<EnemyAI>();
    }

    private void FixedUpdate()
    {
        if (ai.isInSight)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        currTime += Time.fixedDeltaTime;
        if (currTime >= shootingPeriod)
        {
            GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(firepoint.right * bulletForce, ForceMode.Impulse);
            currTime = 0;
        }
    }

}
