using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.Threading;

public class TimeManager : MonoBehaviour
{
    TimeSpan ts;
    Stopwatch stopWatch;
    // Start is called before the first frame update
    void Start()
    {
        stopWatch = new Stopwatch();
        stopWatch.Start();
        ts = stopWatch.Elapsed;
    }

    // Update is called once per frame
    void Update()
    {
        ts = stopWatch.Elapsed;
        UnityEngine.Debug.Log(ts.TotalSeconds);

    }
}
