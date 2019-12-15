using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public static float speed = 1.0f;

    private Rigidbody rb;

    public LayerMask groundLayers;

    public float jumpForce = 7;

    public CapsuleCollider col;

    bool xd = false;

    TimeSpan ts;
    Stopwatch stopWatch;
    bool idleplz = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float straffe = Input.GetAxis("Horizontal") * speed*10;
        straffe *= Time.deltaTime;

        if (straffe > 0)
        {
            GetComponent<Animator>().SetTrigger("D");
        }else
        {
            GetComponent<Animator>().SetTrigger("NotD");
        }

        transform.Translate(straffe, 0, 0);

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("Jump");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            xd = true;
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        ts = stopWatch.Elapsed;


        if (xd && ts.Milliseconds > 100)
        {
            GetComponent<Animator>().SetTrigger("haha");

        }

        if (xd && IsGrounded() && ts.Milliseconds > 100)
        {
            GetComponent<Animator>().SetTrigger("DoneJump");
            xd = false;
            idleplz = true;
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        if (idleplz)
        {
            GetComponent<Animator>().SetTrigger("ok");
            idleplz = false;
        }



    }

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
    }
}
