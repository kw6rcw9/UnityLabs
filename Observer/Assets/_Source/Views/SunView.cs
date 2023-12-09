using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class SunView : MonoBehaviour
{
    [SerializeField] private float morningPos;
    [SerializeField] private float nightPos;
    [SerializeField] private float dayPos;
    [SerializeField] private float eveningPos;
    private void Awake()
    {
        transform.rotation = Quaternion.Euler(0, 0, nightPos);
        Sun.OnUpdateSunPosition += UpdatePos;
    
    }

    private void OnDisable()
    {
        Sky.OnSkyChange -= UpdatePos;
    }

    public void SetMorning(float time) => Rotating(morningPos, time);

    public void SetNight(float time) => Rotating(nightPos, time);
    public void SetDay(float time) => Rotating(dayPos, time);
    public void SetEvening(float time) => Rotating(eveningPos, time);

    private void UpdatePos(DayState dayState, float time)
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
    public void  Rotating(float newPos, float time)
    {
        transform.DORotateQuaternion(Quaternion.Euler(0,0,newPos), time );

    }
}
