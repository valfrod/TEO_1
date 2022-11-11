using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatforms : MonoBehaviour
{
    public List<Transform> waypoints;
    public float moveSpeed;
    public int target;


    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[target].position, moveSpeed * Time.deltaTime);
        Move();        
    }

    private void Move()
    {
        if (transform.position == waypoints[target].position)
        {
            if (target == waypoints.Count - 1)
            {
                target = 0;
            }
            else
            {
                target += 1;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform);
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }
}
