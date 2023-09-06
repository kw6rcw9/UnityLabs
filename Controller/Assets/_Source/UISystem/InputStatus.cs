using System;
using InputSystem;
using TMPro;
using UnityEngine;

namespace UISystem
{
    public class InputStatus : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;
        [SerializeField] private InputListener inputListener;

       

        void Update()
        {
            ShowText();
        
        }

        private void ShowText()
        {
            if(inputListener.InputEnabled == false)
                text.gameObject.SetActive(true);
            else
            {
                text.gameObject.SetActive(false);
            }

        }
    }
}
