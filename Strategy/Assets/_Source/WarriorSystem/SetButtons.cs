using System.Collections.Generic;
using System.Linq;
using EnemySystem;
using UnityEngine;
using UnityEngine.UI;

namespace WarriorSystem
{
    public class SetButtons : MonoBehaviour
    {
        [SerializeField] private Button firstButton;
        [SerializeField] private Button secondButton;
        [SerializeField] private Button thirdButton;
        [SerializeField] private GameObject spawnPoint;
        private IContext _context;
        private List<Button> buttons;
        private SetEnemy _setEnemy;
    

        public void Construct(IContext context, SetEnemy setEnemy)
        {
            _setEnemy = setEnemy;
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
           _setEnemy.ChangeActiveEnemy(new FirstEnemy(), spawnPoint);
            
            
        }
        private void SetSecondStrategy()
        {
            ResetColors();
            secondButton.image.color = Color.red;
            _context.SetStrategy(new SecondAttack());
            _setEnemy.ChangeActiveEnemy(new SecondEnemy(), spawnPoint);
        }
        public void SetThirdStrategy()
        {
            ResetColors();
            thirdButton.image.color = Color.red;
            _context.SetStrategy(new ThirdAttack());
            _setEnemy.ChangeActiveEnemy(new ThirdEnemy(), spawnPoint);
        }

        private void ResetColors()
        {
            var button = buttons.FirstOrDefault(x => x.image.color == Color.red);
            if(button != null)
                button.image.color = Color.white;

        }
    }
}
