using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="AIData/AIData")]
public class AIData : ScriptableObject
{
    public int damage,maxEnergy,maxHp;
    public float energyPerAttack;
    public Vector2 attackRateMinMax;

}
