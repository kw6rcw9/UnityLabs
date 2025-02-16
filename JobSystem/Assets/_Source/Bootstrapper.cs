using System;
using UnityEngine;

namespace _Source
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private CyclicJobProcessor cyclicJobProcessor;
        [SerializeField] private LogarithmJobProcessor logarithmJobProcessor;

        private void Awake()
        {
            cyclicJobProcessor.Init();
            logarithmJobProcessor.Init();
        }
    }
}
