using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : IObserver
{
    public static Action<DayState, float> OnStarsChange;


    public void Update(DayState dayState, float time)
    {
        OnStarsChange?.Invoke(dayState, time);
    }
}
