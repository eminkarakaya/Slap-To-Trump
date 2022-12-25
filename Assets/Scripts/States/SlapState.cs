using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlapState : PlayerStateBase
{
    [SerializeField] private bool coolDown = true;
    [SerializeField] private Animator anim;
    [SerializeField] private PlayerData playerData;
    Player player;
    public void Slap()
    {
        float random = Random.Range(1, 5);
        anim.SetTrigger("Punch4");
        Debug.Log("Punch" + random);
        Enemy.instance.GetComponent<Health>().Hit("hit1",playerData.damage);
    }
    public override void StartState()
    {
        player = Player.instance;
        anim = player.anim;
    }

    public override void UpdateState()
    {
        if(playerInput.isClick && coolDown)
        {
            Slap();
        }
    }
    public void FalseCooldown()
    {
        coolDown = false;
    }
    public void TrueCooldown()
    {
        coolDown = true;
    }
}
