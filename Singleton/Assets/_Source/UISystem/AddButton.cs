using System;
using System.Runtime.CompilerServices;
using ResourceSystem;
using Singletons;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

namespace UISystem
{
    public class AddButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private TMP_InputField inputField;
        [SerializeField] private TMP_Dropdown dropdown;

        private void Awake()
        {
            ButtonClick();
        }

        private void Update()
        {
            if (inputField.text.Trim() == "")
                inputField.text = 0.ToString();
        }

        void ButtonClick()
        {
            button.onClick.AddListener(() =>ResourceBank.Instance.AddResource((ResourceType)dropdown.value,  int.Parse(inputField.text.Trim())));
            
        }
        
    }
}
