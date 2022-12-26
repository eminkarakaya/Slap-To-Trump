using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaitState : EnemyStateBase
{
    private void OnEnable()
    {
        WalkState.OnSlap += SlapState;
    }
    private void OnDisable()
    {
        WalkState.OnSlap -= SlapState;
    }
    public override void StartState()
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState()
    {
        
    }
    public void SlapState()
    {
        Enemy.instance.CurrentState = Enemy.instance.enemySlapState;
    }
}
