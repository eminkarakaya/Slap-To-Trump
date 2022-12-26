using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyStateBase : MonoBehaviour
{
    
    public abstract void StartState();
    public abstract void UpdateState();
}
