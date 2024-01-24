using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace WarriorSystem
{
    public class SetButtons : MonoBehaviour
    {
        [SerializeField] private Button firstButton;
        [SerializeField] private Button secondButton;
        [SerializeField] private Button thirdButton;
        private IContext _context;
        private List<Button> buttons;

        public void Construct(IContext context)
        {
            buttons = new List<Button>();
            _context = context;
            firstButton.onClick.AddListener(SetFirstStrategy);
            buttons.Add(firstButton);
            secondButton.onClick.AddListener(SetSecondStrategy);
            buttons.Add(secondButton);
            thirdButton.onClick.AddListener(SetThirdStrategy);
            buttons.Add(thirdButton);
        }
        public SetButtons(IContext context)
        {
            _context = context;
        }
        private void SetFirstStrategy()
        {
            ResetColors();
            firstButton.image.color = Color.red;
            _context.SetStrategy(new FirstAttack());
        }
        private void SetSecondStrategy()
        {
            ResetColors();
            secondButton.image.color = Color.red;
            _context.SetStrategy(new SecondAttack());
        }
        public void SetThirdStrategy()
        {
            ResetColors();
            thirdButton.image.color = Color.red;
            _context.SetStrategy(new ThirdAttack());
        }

        private void ResetColors()
        {
            var button = buttons.FirstOrDefault(x => x.image.color == Color.red);
            if(button != null)
                button.image.color = Color.white;

        }
    }
}
