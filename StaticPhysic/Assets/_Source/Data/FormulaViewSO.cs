using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewFormulaViewSO", menuName = "SO/New Formula View")]
public class FormulaViewSO : ScriptableObject
{
   [field: SerializeField] public string FirstFormula { get; private set; }
   [field: SerializeField] public string SecondFormula { get; private set; }
}
