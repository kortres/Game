using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firepoint;
    private Vector3 lookDir;
    private Ray los;
    private RaycastHit rh;

    public float bulletForce;
    public float shootingPeriod;
    private float currTime;

    private void Start()
    {
       lookDir = GetComponent<EnemyAI>().lookDir;
    }

    private void Update()
    {
        Shoot();
        los = new Ray(transform.position, lookDir);
        if (Physics.Raycast(los, out rh))
        {
            if (rh.collider.gameObject.tag == "Player")
            {
                Shoot();
            }
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
