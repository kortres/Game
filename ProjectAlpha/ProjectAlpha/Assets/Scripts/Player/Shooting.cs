using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    public float bulletForce;
    public float shootingPeriod;
    private float currTime;

    private bool isShooting = false;

    private void Start()
    {
        currTime = shootingPeriod;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isShooting = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isShooting = false;
            currTime = shootingPeriod;
        }
    }
    private void FixedUpdate()
    {
        if (isShooting)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        currTime += Time.fixedDeltaTime;
        if (currTime >= shootingPeriod)
        {
            GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(-firepoint.right * bulletForce, ForceMode.Impulse);
            currTime = 0;
        }
    }
}
