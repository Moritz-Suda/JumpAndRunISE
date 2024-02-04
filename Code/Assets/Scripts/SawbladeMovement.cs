using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawbladeMovement : MonoBehaviour
{
    public Transform waypointStart;
    public Transform waypointEnd;
    public float speed = 5.0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        MoveToWaypoint(waypointEnd);
    }

    private void MoveToWaypoint(Transform targetWaypoint)
    {
        Vector3 direction = (targetWaypoint.position - transform.position).normalized;
        rb.velocity = direction * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == waypointEnd)
        {
            MoveToWaypoint(waypointStart);
        }
        else if (other.transform == waypointStart)
        {
            MoveToWaypoint(waypointEnd);
        }
    }
}
