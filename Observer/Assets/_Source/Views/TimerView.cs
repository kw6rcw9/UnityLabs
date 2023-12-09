using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class TimerView : MonoBehaviour
{
    [SerializeField] private int dayDuration;
    private Timer _timer;
  
    public void Construct(Timer timer)
    {
        _timer = timer;
        StartCoroutine(_timer.StartTimer(dayDuration));
    }

    
}
