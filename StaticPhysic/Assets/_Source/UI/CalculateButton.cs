using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.UI;

namespace UI
{
    public class CalculateButton : MonoBehaviour
    {
        [SerializeField] private TMP_InputField m1;
        [SerializeField] private TMP_InputField m2;
        [SerializeField] private TMP_InputField r;
        [SerializeField] private TMP_InputField u;
        [SerializeField] private TMP_InputField m;
        [SerializeField] private TMP_Text resultFirstText;
        [SerializeField] private TMP_Text resultSecondText;
        [SerializeField] private Button firstButton;
        [SerializeField] private Button secondButton;

        private void Start()
        {
            firstButton.onClick.AddListener(FirstFormula);
            secondButton.onClick.AddListener(SecondFormula);
        }

        private void Update()
        {
            if (String.IsNullOrEmpty(m1.text))
            {
                firstButton.interactable = false;
            }
            else if (String.IsNullOrEmpty(m2.text))
            {
                firstButton.interactable = false;
            }
            else if (String.IsNullOrEmpty(r.text))
            {
                firstButton.interactable = false;
            }
            else
            {
                firstButton.interactable = true;
            }
            if (String.IsNullOrEmpty(u.text))
            {
                secondButton.interactable = false;
            }
            else if (String.IsNullOrEmpty(m.text))
            {
                secondButton.interactable = false;
            }
            else
            {
                secondButton.interactable = true;
            }
            

            
        }


        public void FirstFormula()
        {
            var result =FormulaCalculator.FirstFormulaCalculate(Double.Parse(m1.text), Double.Parse(m2.text), Double.Parse(r.text));
            resultFirstText.text = result.ToString(CultureInfo.InvariantCulture);

        }
        public void SecondFormula()
        {
            var result =FormulaCalculator.SecondFormulaCalculate(Double.Parse(m.text), Double.Parse(u.text));
            resultSecondText.text = result.ToString(CultureInfo.InvariantCulture);

        }
    }
}
