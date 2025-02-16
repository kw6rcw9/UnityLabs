using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

namespace _Source
{
    public class CyclicJobProcessor : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private float speed;
        [SerializeField] private int spawnCount;
        [SerializeField] private float radius;
     
        private Transform[] _transforms;
        private TransformAccessArray _transformAccessArray;

        NativeArray<int> _numberLogs;

        private void Update()
        {
            HandleMovementJob();
        }
    
        public void Init()
        {
            _transforms = new Transform[spawnCount];
            float num = 0;
            for(int i = 0; i < spawnCount; i++)
            {
                Transform instanceTransform = Instantiate(prefab, new Vector3(0,0,0 + num), Quaternion.identity).transform;
                _transforms[i] = instanceTransform;
                num += 0.25f;
            }
            _transformAccessArray = new TransformAccessArray(_transforms);
            _numberLogs = new NativeArray<int>(spawnCount, Allocator.Persistent);
        }

        private void HandleMovementJob()
        {
            MovementJOB movementJob = new MovementJOB(speed, radius);
            JobHandle jobHandle = movementJob.Schedule(_transformAccessArray);
            jobHandle.Complete();
        }

        private void OnDestroy()
        {
            _transformAccessArray.Dispose();
            _numberLogs.Dispose();
        }

    }
}
