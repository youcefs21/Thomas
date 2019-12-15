using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinArm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.ts.TotalSeconds > 68 && TimeManager.ts.TotalSeconds < 88)
        {
            transform.Translate(0, -15f * Time.deltaTime, 0);
            transform.Rotate(0, 0, -10f * Time.deltaTime);
        }
    }
}
