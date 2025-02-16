using System.Collections;
using UnityEngine;
using Random = System.Random;

namespace _Source
{
    public class LogarithmJobProcessor : MonoBehaviour
    {
        [SerializeField] private int delay;
        [SerializeField] private int objectAmount;
        private Random _random = new Random();
    

        public void Init()
        {
            for (int i = 0; i < objectAmount; i++)
            {
                StartCoroutine(RegurlarExcecution(delay));
            }
        }

        public void GetFactorialOfRundomNumber(int min, int max)
        {
            LogarithmJob logarithmJob = new LogarithmJob(_random.Next(min, max));
            logarithmJob.Execute();
        }

        IEnumerator RegurlarExcecution(int n)
        {
            while (true)
            {
                GetFactorialOfRundomNumber(0, 100);
                yield return new WaitForSeconds(n);
            }
        }

    }
}
