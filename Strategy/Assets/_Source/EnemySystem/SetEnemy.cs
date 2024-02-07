using System.Collections;
using System.Collections.Generic;
using EnemySystem;
using TMPro;
using UnityEngine;

public class SetEnemy
{
    private ABaseClass _currentEnemy;
    public SetEnemy(ABaseClass enemy)
    {
        _currentEnemy = enemy;
    }

    public void  ChangeActiveEnemy(ABaseClass newAnemy)
    {
        _currentEnemy = newAnemy;
    }

    public void Attack()
    {
        _currentEnemy.TemplateAttack();
    }


}
