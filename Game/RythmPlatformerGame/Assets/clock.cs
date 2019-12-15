using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{

    bool right = false;
    float basehaha = 1.266f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.ts.TotalSeconds > 23.46800-basehaha/2 && TimeManager.ts.TotalSeconds < 24.73400-basehaha)
        {
            transform.Rotate(0, 0, -20f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 23.46800 && TimeManager.ts.TotalSeconds < 24.73400)
        {
            transform.Rotate(0, 0, 60f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 24.73400 && TimeManager.ts.TotalSeconds < 26)
        {
            transform.Rotate(0, 0, -80f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 26 && TimeManager.ts.TotalSeconds < 26+ basehaha)
        {
            transform.Rotate(0, 0, 80f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 26 + (basehaha * 1) && TimeManager.ts.TotalSeconds < 26 + (basehaha*2))
        {
            transform.Rotate(0, 0, -80f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 26 + (basehaha * 2) && TimeManager.ts.TotalSeconds < 26 + (basehaha * 3))
        {
            transform.Rotate(0, 0, 80f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 26 + (basehaha * 3) && TimeManager.ts.TotalSeconds < 26 + (basehaha * 4))
        {
            transform.Rotate(0, 0, -80f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 26 + (basehaha * 4) && TimeManager.ts.TotalSeconds < 26 + (basehaha * 5))
        {
            transform.Rotate(0, 0, 80f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 26 + (basehaha * 5) && TimeManager.ts.TotalSeconds < 26 + (basehaha * 6))
        {
            transform.Rotate(0, 0, -80f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 26 + (basehaha * 6) && TimeManager.ts.TotalSeconds < 26 + (basehaha * 7))
        {
            transform.Rotate(0, 0, -80f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 26 + (basehaha * 7) && TimeManager.ts.TotalSeconds < 26 + (basehaha * 8))
        {
            transform.Rotate(0, 0, -80f * Time.deltaTime);
        }
        if (TimeManager.ts.TotalSeconds > 26 + (basehaha * 8) && TimeManager.ts.TotalSeconds < 27 + (basehaha * 9))
        {
            transform.Rotate(0, 0, -160f * Time.deltaTime);
        }

    }
}
