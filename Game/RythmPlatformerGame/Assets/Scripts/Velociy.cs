﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velociy : MonoBehaviour
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
            transform.Translate(0, -50f * Time.deltaTime, 0);
        }
    }
}
