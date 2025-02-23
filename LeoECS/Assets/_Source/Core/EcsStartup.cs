using _Source.Systems;
using Leopotam.EcsLite;
using Voody.UniLeo.Lite;

namespace _Source.Core
{
    public class EcsStartup : UnityEngine.MonoBehaviour
    {
        private EcsWorld _world;
        private EcsSystems _systems;

        void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);
            _systems
                .ConvertScene()
                .Add(new IncrementSystem())
                .Add(new ZigZagMovementSystem())
                .Init();
        }

        void Update()
        {
            _systems?.Run();
        }

        void OnDestroy()
        {
            if (_systems != null)
            {
                _systems.Destroy();
                _systems = null;
            }
    
            if (_world != null)
            {
                _world.Destroy();
                _world = null;
            }
        }
    }
}
