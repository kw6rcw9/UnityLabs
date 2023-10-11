using System;
using System.Collections.Generic;
using ResourceSystem;
using TMPro;
using UnityEngine;

namespace UISystem
{
    public class ResourceTypeList : MonoBehaviour
    {
        [SerializeField] private TMP_Dropdown dropdown;
        private void Awake()
        {
            AddOptions();
        }

        private void AddOptions()
        {
            string[] names = Enum.GetNames(typeof(ResourceType));
            List<string> list = new List<string>(names);
            dropdown.AddOptions(list);
            
        }
    }
}
