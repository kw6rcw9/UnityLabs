using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable
{
    bool RegisterObserver(IObserver observer);
    bool RemoveObserver(IObserver observer);
    void Notify(float time);
}
