using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    public static Enemy instance;
    public EnemySlapState enemySlapState;
    public EnemyDeathState enemyDeathState;
    public EnemyWaitState enemyWaitState;
    [SerializeField] private EnemyStateBase _currentState;
    public Animator anim;

    public EnemyStateBase CurrentState
    {
        get => _currentState;
        set
        {
            _currentState = value;
            _currentState.StartState();
        }
    }
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        anim = GetComponent<Animator>();

    }
    private void Update()
    {
        if (CurrentState != null)
            CurrentState.UpdateState();

    }
    public void FalseCoolDown()
    {
        enemySlapState.FalseCooldown();
    }
    public void TrueCoolDown()
    {
        enemySlapState.TrueCooldown();
    }
}
