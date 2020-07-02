using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //private Rigidbody player;
    private Rigidbody enemy;
    public Rigidbody player { get; private set; }

    public Vector3 lookDir { get; private set; }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        enemy = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        lookDir = player.position - enemy.position; 
        float angle = Mathf.Atan2(lookDir.z, lookDir.x) * Mathf.Rad2Deg;
        enemy.rotation = Quaternion.AngleAxis(angle, -Vector3.up);
    }
}
