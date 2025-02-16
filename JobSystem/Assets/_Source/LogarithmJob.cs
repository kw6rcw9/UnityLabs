using System;
using Unity.Jobs;
using UnityEngine;

namespace _Source
{
    public struct LogarithmJob : IJob
    {
        private int _randomNumber;
    

        public LogarithmJob(int randomNumber)
        {
            _randomNumber = randomNumber;
        }

        public void Execute()
        {
            Debug.Log($"Logarithm of {_randomNumber} is {Math.Log(_randomNumber)}");
        }
    
    
    }
}
