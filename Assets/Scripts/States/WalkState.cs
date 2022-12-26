using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class WalkState : PlayerStateBase
{
    public static event System.Action OnSlap;
    private void OnEnable()
    {
        OnSlap += SlapState;
    }
    private void OnDisable()
    {
        OnSlap -= SlapState;
    }
    public override void StartState()
    {
           
        Player.instance.transform.DOMove(GameManager.instance.fightPlace.position, 1f).OnComplete(()=> OnSlap?.Invoke());
    }

    public override void UpdateState()
    {
        
    }
    public void SlapState()
    {
        Player.instance.CurrentState = Player.instance.slapState;
    }
}
