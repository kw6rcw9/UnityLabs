using TMPro;
using UnityEngine;

namespace UI
{
    public class FormulaText : MonoBehaviour
    {
        [SerializeField] private TMP_Text firstFormula;
        [SerializeField] private TMP_Text secondFormula;
        private FormulaViewSO _formulaView;

        public void Construct(FormulaViewSO formulaView)
        {
            _formulaView = formulaView;
            firstFormula.text = formulaView.FirstFormula;
            secondFormula.text = formulaView.SecondFormula;

        }

    }
}
