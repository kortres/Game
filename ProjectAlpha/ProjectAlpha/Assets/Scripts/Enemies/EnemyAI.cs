using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //private Rigidbody player;
    public Rigidbody player { get; private set; }
    public string enemyTag;
    private Rigidbody enemy;
    private Ray los;
    private RaycastHit losHit;


    public Vector3 lookDir { get; private set; }
    public bool isInSight
    {
        get
        {
            if (Physics.Raycast(los, out losHit))
            {
                if (losHit.collider.gameObject.tag == enemyTag)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag(enemyTag).GetComponent<Rigidbody>();
        enemy = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (player != null)
        {
            lookDir = player.position - enemy.position;
            los = new Ray(transform.position, lookDir);
            if (isInSight)
            {
                float angle = Mathf.Atan2(lookDir.z, lookDir.x) * Mathf.Rad2Deg;
                enemy.rotation = Quaternion.AngleAxis(angle, -Vector3.up);
            }
        }
    }
}
