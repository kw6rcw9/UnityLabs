using _Source.Components;
using Leopotam.EcsLite;
using UnityEngine;

namespace _Source.Systems
{
    public class IncrementSystem : IEcsInitSystem, IEcsRunSystem
    {
        private EcsPool<CounterComponent> _counterComponents;
        private EcsFilter _counterComponentFilter;

        public void Init(IEcsSystems systems)
        {
            var world = systems.GetWorld();
            _counterComponents = world.GetPool<CounterComponent>();
            _counterComponentFilter = world.Filter<CounterComponent>()
                .End();
        }

        public void Run(IEcsSystems systems)
        {
            foreach(var entity in _counterComponentFilter)
            {
                ref CounterComponent counterComponent = ref _counterComponents.Get(entity);
                counterComponent.Count++;
                Debug.Log(counterComponent.Count);
            }
        }
    }
}
