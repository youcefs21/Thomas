using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.ts.TotalSeconds > 54)
        {
            transform.Rotate(0, -5f * Time.deltaTime, -20f * Time.deltaTime);
        }
    }
}
