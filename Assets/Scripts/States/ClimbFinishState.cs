using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbFinishState : PlayerStateBase
{
    public override void StartState()
    {
        Player.instance.anim.SetBool("Finish", true);
    }

    public override void UpdateState()
    {
        
    }
}
