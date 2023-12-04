using System;
using Data;
using UI;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private FormulaViewSO formulaViewSo;
        [SerializeField] private PhysicConstSO physicConstSo;
        [SerializeField] private FormulaText formulaText;
        private FormulaCalculator _formulaCalculator;

        private void Awake()
        {
            _formulaCalculator = new FormulaCalculator(physicConstSo);
            formulaText.Construct(formulaViewSo);
            
        }
    }
}
