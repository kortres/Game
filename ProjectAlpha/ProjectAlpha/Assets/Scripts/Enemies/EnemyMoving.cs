using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    public float moveSpeed;

    private EnemyAI ai;
    private Rigidbody rb;

    private Vector3 movement;

    private void Start()
    {
        ai = GetComponent<EnemyAI>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //if (ai.isInSight)
        //{
        //    movement = ai.lookDir;
        //}
        //else
        //{
        //    movement = ai.LastSpot.point - rb.position;
        //}
    }

    private void FixedUpdate()
    {
        if (ai.isInSight)
        {
            transform.position += transform.forward * moveSpeed * Time.fixedDeltaTime;
        }
        //rb.MovePosition(Vector3.forward * moveSpeed * Time.fixedDeltaTime);
    }
}
