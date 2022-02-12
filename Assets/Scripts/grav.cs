using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grav : MonoBehaviour

{

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (TimeManager.ts.TotalSeconds > 18)
        {
            transform.Rotate(0, -5f * Time.deltaTime, -20f * Time.deltaTime);
            rb.useGravity = true;
        }
    }


}
