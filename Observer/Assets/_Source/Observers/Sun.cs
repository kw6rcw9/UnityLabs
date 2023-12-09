using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : IObserver
{
    public static Action<DayState, float> OnUpdateSunPosition;

    public void Update(DayState dayState, float time)
    {
        OnUpdateSunPosition?.Invoke(dayState, time);
    }
}
