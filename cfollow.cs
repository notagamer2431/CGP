using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cfollow : MonoBehaviour
{
    public Transform plr;
    public Vector3 cords;
   
    void Start()
    {

    }

    
    void Update()
    {
        transform.position = plr.position + cords;
    }
}
