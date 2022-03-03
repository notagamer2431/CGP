using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
   
    
    public Rigidbody rb;
    public float front = 0f;
    public float side = 0f;
    public float back = 0f;
    public int up;





    void Start()
    {

    }


    void FixedUpdate()
    {
        if (Input.GetKey("w"))

        {
            rb.AddForce(0, 0, front * Time.deltaTime);
        }
        if (Input.GetKey("d"))

        {
            rb.AddForce(side * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))

        {
            rb.AddForce(-side * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))

        {
            rb.AddForce(0, 1, -back * Time.deltaTime);
        }

        if ((Input.GetKey(KeyCode.Space)))
        {

            rb.AddForce(0, up * Time.deltaTime, 0);
        }

    }
}
