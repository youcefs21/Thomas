using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.ts.TotalSeconds > 2)
        {
            transform.Translate(5f * Time.deltaTime, 0, 0);
        }

        if (TimeManager.ts.TotalSeconds > 23 && TimeManager.ts.TotalSeconds < 25.5)
        {
            transform.Translate(5f * Time.deltaTime, -10f * Time.deltaTime, 0);
        }
    }





}
