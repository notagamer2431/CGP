using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    public GameObject[] wps;

    int movementspeed = 0;

    float rotation;

    public float speed;

    float radiuswaypoint = 1;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Vector3.Distance(wps[movementspeed].transform.position, transform.position) < radiuswaypoint)
        {
            movementspeed = Random.Range(0, wps.Length);
            if (movementspeed >= wps.Length)
            {
                movementspeed = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wps[movementspeed].transform.position, Time.deltaTime * speed);

    }
}
