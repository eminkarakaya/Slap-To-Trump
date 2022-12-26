using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySlapState : EnemyStateBase
{
    [SerializeField] private bool coolDown = true;
    [SerializeField] private Animator anim;
    [SerializeField] private AIData aiData;
    [SerializeField] private float _currentEnergy;
    [SerializeField] private Slider energySlider;
    [SerializeField] float time, tempTime;
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
        time = Random.Range(aiData.attackRateMinMax.x, aiData.attackRateMinMax.y);
        tempTime = time;
    }

    public override void UpdateState()
    {
        tempTime-= Time.deltaTime;
        if (tempTime < 0 && !coolDown)
        {
            time = Random.Range(aiData.attackRateMinMax.x, aiData.attackRateMinMax.y);
            tempTime = time;
            Slap();
        }


    }
    public void Slap()
    {
        if (_currentEnergy < aiData.energyPerAttack)
        {
            return;
        }
        _currentEnergy -= aiData.energyPerAttack;
        float random = Random.Range(1, 5);
        anim.SetTrigger("Punch2");
        Player.instance.GetComponent<Health>().Hit("hit1", aiData.damage);

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
