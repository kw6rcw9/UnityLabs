using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "NewPhysicConstSO", menuName = "SO/New Physic Const")]
    public class PhysicConstSO : ScriptableObject
    {
        //формула силы трения
        //формула закона

        [field: Header("Гравитационная постоянная")]
        [field: SerializeField]
        public double Gr { get; private set; }

        [field: Header("Ускорение свободного падения")]
        [field: SerializeField]
        public double G { get; private set; }
    }
}
