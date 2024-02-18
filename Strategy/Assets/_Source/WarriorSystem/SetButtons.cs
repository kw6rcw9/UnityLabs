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
        [SerializeField] private GameObject bulletPref;
        [SerializeField] private Transform firePoint;
        private IContext _context;
        private List<Button> _buttons;
        private SetEnemy _setEnemy;
    

        public void Construct(IContext context, SetEnemy setEnemy)
        {
            _setEnemy = setEnemy;
            _buttons = new List<Button>();
            _context = context;
            firstButton.onClick.AddListener(SetFirstStrategy);
            _buttons.Add(firstButton);
            secondButton.onClick.AddListener(SetSecondStrategy);
            _buttons.Add(secondButton);
            thirdButton.onClick.AddListener(SetThirdStrategy);
            _buttons.Add(thirdButton);
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
           _setEnemy.ChangeActiveEnemy(typeof(FirstEnemy), spawnPoint);
            
            
        }
        private void SetSecondStrategy()
        {
            ResetColors();
            secondButton.image.color = Color.red;
            _context.SetStrategy(new SecondAttack());
            Debug.Log(bulletPref);
            _setEnemy.ChangeActiveEnemy(typeof(SecondEnemy), spawnPoint);
        }
        public void SetThirdStrategy()
        {
            ResetColors();
            thirdButton.image.color = Color.red;
            _context.SetStrategy(new ThirdAttack());
            _setEnemy.ChangeActiveEnemy(typeof(ThirdEnemy), spawnPoint);
        }

        private void ResetColors()
        {
            var button = _buttons.FirstOrDefault(x => x.image.color == Color.red);
            if(button != null)
                button.image.color = Color.white;

        }
    }
}
