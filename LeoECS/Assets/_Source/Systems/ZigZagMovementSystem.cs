using _Source.Components;
using Leopotam.EcsLite;
using UnityEngine;

namespace _Source.Systems
{
    public class ZigZagMovementSystem : IEcsInitSystem, IEcsRunSystem
    {
        private EcsPool<MovementComponent> _counterComponents;
        private EcsFilter _counterComponentFilter;
    
        private float time;
    
        public void Init(IEcsSystems systems)
        {
            var world = systems.GetWorld();

            _counterComponents = world.GetPool<MovementComponent>();
            _counterComponentFilter = world.Filter<MovementComponent>()
                .End();
        }

        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _counterComponentFilter)
            {
                ref MovementComponent counterComponent = ref _counterComponents.Get(entity);

                ZigZagMovement(counterComponent.Ball ,counterComponent.Speed, counterComponent.Magnitude, counterComponent.Frequency);
            }
        }

        public void ZigZagMovement(Transform transform, float speed, float amplitude, float frequency)
        {
            time += Time.deltaTime;
        
            float xOffset = Mathf.Sin(time * frequency) * amplitude;
        
            transform.position += new Vector3(xOffset, 0, speed * Time.deltaTime);
        }
    }
}
