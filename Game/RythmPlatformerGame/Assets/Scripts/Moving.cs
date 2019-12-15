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

        Debug.Log(TimeManager.ts.TotalSeconds);
        if (TimeManager.ts.TotalSeconds > 2 && TimeManager.ts.TotalSeconds < 66)
        {
            transform.Translate(5f * Time.deltaTime, 0, 0);
            Controls.speed = 0.9f;
        }

        if (TimeManager.ts.TotalSeconds > 66 && TimeManager.ts.TotalSeconds < 67)
        {
            transform.Translate(4.5f * Time.deltaTime, 0, 0);
            Controls.speed = 0.8f;

        }
        if (TimeManager.ts.TotalSeconds > 67 && TimeManager.ts.TotalSeconds < 68)
        {
            transform.Translate(4f * Time.deltaTime, 0, 0);
            Controls.speed = 0.7f;
        }
        if (TimeManager.ts.TotalSeconds > 68 && TimeManager.ts.TotalSeconds < 69)
        {
            transform.Translate(3.5f * Time.deltaTime, 0, 0);
            Controls.speed = 0.6f;

        }
        if (TimeManager.ts.TotalSeconds > 69 && TimeManager.ts.TotalSeconds < 70)
        {
            transform.Translate(3f * Time.deltaTime, 0, 0);
            Controls.speed = 0.5f;

        }
        if (TimeManager.ts.TotalSeconds > 70 && TimeManager.ts.TotalSeconds < 71)
        {
            transform.Translate(2.5f * Time.deltaTime, 0, 0);
            Controls.speed = 0.45f;

        }
        if (TimeManager.ts.TotalSeconds > 71 && TimeManager.ts.TotalSeconds < 92)
        {
            transform.Translate(2f * Time.deltaTime, 0, 0);
            Controls.speed = 0.4f;
        }

        if (TimeManager.ts.TotalSeconds > 92 && TimeManager.ts.TotalSeconds < 200)
        {
            transform.Translate(6f * Time.deltaTime, 0, 0);
            Controls.speed = 1f;
        }

        if (TimeManager.ts.TotalSeconds > 23 && TimeManager.ts.TotalSeconds < 25.5)
        {
            transform.Translate(5f * Time.deltaTime, -10f * Time.deltaTime, 0);
        }
    }





}
