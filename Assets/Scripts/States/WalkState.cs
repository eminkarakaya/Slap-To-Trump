using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class WalkState : PlayerStateBase
{
    public override void StartState()
    {
           
        Player.instance.transform.DOMove(GameManager.instance.fightPlace.position, 1f).OnComplete(()=>Player.instance.CurrentState = Player.instance.slapState);
    }

    public override void UpdateState()
    {
        
    }
}
