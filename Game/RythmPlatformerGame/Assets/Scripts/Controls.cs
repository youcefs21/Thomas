using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public static float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float straffe = Input.GetAxis("Horizontal") * speed*10;
        straffe *= Time.deltaTime;


        transform.Translate(straffe, 0, 0);
    }
}
