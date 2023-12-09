using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
   [SerializeField] private TimerView timerView;
   private IObserver _sun;
   private IObservable _timer;
   private IObserver _sky;
   private IObserver _stars;

   private void Awake()
   {
      _sky = new Sky();
      _timer = new Timer();
      _sun = new Sun();
      _stars = new Stars();
      _timer.RegisterObserver(_sky);
      _timer.RegisterObserver(_sun);
      _timer.RegisterObserver(_stars);
      timerView.Construct(_timer as Timer);
   }
   

   private void OnDestroy()
   {
      _timer.RemoveObserver(_sky);
      _timer.RemoveObserver(_sun);
      _timer.RemoveObserver(_stars);
   }
}
