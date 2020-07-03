using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //private Rigidbody player;
    public Rigidbody player { get; private set; }
    public RaycastHit LastSpot { get => lastSpot; private set => lastSpot = value; }
    public string enemyTag;
    public float angleOffset;
    private Rigidbody enemy;
    private Ray los;
    private RaycastHit losHit;
    private RaycastHit lastSpot;

    public Vector3 lookDir { get; private set; }
    public bool isInSight
    {
        get
        {
            if (Physics.Raycast(los, out losHit))
            {
                if (losHit.collider.gameObject.tag == enemyTag)
                {
                    lastSpot = losHit;
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
        lastSpot.point = transform.position;
    }

    private void Update()
    {
        Debug.Log(lastSpot.point);
        if (player != null)
        {
            lookDir = player.position - enemy.position;
            los = new Ray(transform.position, lookDir);
            if (isInSight)
            {
                float angle = Mathf.Atan2(lookDir.z, lookDir.x) * Mathf.Rad2Deg + angleOffset;
                enemy.rotation = Quaternion.AngleAxis(angle, -Vector3.up);
            }
        }
    }
}
