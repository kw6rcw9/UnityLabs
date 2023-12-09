using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;


public class SkyView : MonoBehaviour
{
  [SerializeField] private Camera mainCamera;
  [SerializeField] private Color morningColor;
  [SerializeField] private Color dayColor;
  [SerializeField] private Color eveningColor;
  [SerializeField] private Color nightColor;


  private void Awake()
  {
    mainCamera.backgroundColor = nightColor;
    Sky.OnSkyChange += UpdateSky;
    
  }

  private void OnDisable()
  {
    Sky.OnSkyChange -= UpdateSky;
  }

  public void SetMorning(float time) => SetSkyColor(morningColor, time);

  public void SetNight(float time) => SetSkyColor(nightColor, time);
  public void SetDay(float time) => SetSkyColor(dayColor, time);
  public void SetEvening(float time) => SetSkyColor(eveningColor, time);

  private void UpdateSky(DayState dayState, float time)
  {
    switch (dayState)
    {
      case DayState.Morning:
        SetMorning(time);
        break;
      case DayState.Night:
        SetNight(time);
        break;
      case DayState.Day:
        SetDay(time);
        break;
      case DayState.Evening:
        SetEvening(time);
        break;
    }
  }
  public void  SetSkyColor(Color color, float time)
  {
    mainCamera.DOColor(color,time);

  }
}
