using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStateBase : MonoBehaviour
{
    [SerializeField] protected PlayerInput playerInput;
    public abstract void StartState();
    public abstract void UpdateState();
}
