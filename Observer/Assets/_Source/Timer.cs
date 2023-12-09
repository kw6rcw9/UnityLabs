using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Timer : IObservable
{
    private readonly List<IObserver> _observers;
    private DayState _currDayState;

    public Timer()
    {
        _observers = new List<IObserver>();
    }
    
    
    
    public bool RegisterObserver(IObserver observer)
    {
        bool success = false;
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
            success = true;
        }
            
        return success;
    }

    public bool RemoveObserver(IObserver observer)
    {
        bool success = false;
        if (_observers.Contains(observer))
        {
            _observers.Remove(observer);
            success = true;
        }
            
        return success;
    }

    public void Notify(float time)
    {
        foreach (var observer in _observers)
        {
           
            observer.Update(_currDayState, time);
        }
    }


    public IEnumerator StartTimer(int time)
    {
        var dayTimeDur = time / 4;
        while (true)
        {
           
            for (int i = 0; i < 4; i++)
            {
                
                _currDayState = (DayState)i;
                Notify(dayTimeDur);
                yield return new WaitForSeconds(dayTimeDur);
            }
            
           
        }
        
        
    }
}
