using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3DController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody rb;
    public RaycastHit rh;
    public Ray ray;
    public Camera cam;

    Vector3 movement;
    Vector3 mousePos;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out rh))
        {
            mousePos = rh.point;
            mousePos.y = transform.position.y;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector3 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.z, lookDir.x) * Mathf.Rad2Deg - 180f;
        rb.rotation = Quaternion.AngleAxis(angle, -Vector3.up);
    }
}
