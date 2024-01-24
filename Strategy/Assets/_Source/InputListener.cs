using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializeField] private KeyCode attackKeyCode;
    private AttackPerformer _attackPerformer;
        
    public void Construct(AttackPerformer attackPerformer)
    {
        _attackPerformer = attackPerformer;
    }
        
    private void Update()
    {
        CheckAttack();
    }

    private void CheckAttack()
    {
        if (Input.GetKeyDown(attackKeyCode))
        {
            //_attackPerformer.PerformAttack();
        }
    }
}
