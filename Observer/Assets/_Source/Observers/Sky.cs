using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky: IObserver
{

  

  public static Action<DayState, float> OnSkyChange;


  public void Update(DayState dayState, float time)
  {
    OnSkyChange?.Invoke(dayState, time);
  }
}
