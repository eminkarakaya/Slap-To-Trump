using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlapState : PlayerStateBase
{
    [SerializeField] private GameObject playerCanvas, trumpCanvas;
    [SerializeField] private bool coolDown = true;
    [SerializeField] private Animator anim;
    [SerializeField] private PlayerData playerData;
    Player player;
    [SerializeField] private Slider energySlider;
    [SerializeField] private float _currentEnergy;
    
    public float CurrentEnergy
    {
        get { return _currentEnergy; }
        set 
        {
            _currentEnergy = value;
            energySlider.value = _currentEnergy;
        }
    }
    public override void StartState()
    {
        CameraFollow.instance.enabled = false;
        StartCoroutine(EnergyRecharge());
        energySlider.maxValue = playerData.maxEnergy;
        CurrentEnergy = playerData.maxEnergy;
        player = Player.instance;
        anim = player.anim;
        playerCanvas.SetActive(true);
        trumpCanvas.SetActive(true);
    }

    public override void UpdateState()
    {
        if(playerInput.isClick && coolDown)
        {
            Slap();
        }
    }

    private IEnumerator EnergyRecharge()
    {
        while(true)
        {
            yield return null;
            if(CurrentEnergy < playerData.maxEnergy)
            {
                CurrentEnergy += playerData.rateOfIncrease * Time.deltaTime;
                if(CurrentEnergy > playerData.maxEnergy)
                {
                    CurrentEnergy = playerData.maxEnergy;
                }
            }
        }
    }
    public void Slap()
    {
        //if(CurrentEnergy < playerData.energyPerAttack)
        //{
        //    return;
        //}
        CurrentEnergy -= playerData.energyPerAttack;
        float random = Random.Range(1, 5);
        anim.SetTrigger("Punch4");
        Enemy.instance.GetComponent<Health>().Hit("hit1",playerData.damage);
        
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
