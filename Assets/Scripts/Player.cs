using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    [SerializeField] private ClimbState _climbState;
    public static event System.Action OnWalk;
    
    public SlapState slapState;
    public WalkState walkState;
    public ClimbFinishState climbFinishState;
    [SerializeField] private PlayerStateBase _currentState;
    
    public PlayerStateBase CurrentState { get => _currentState; 
        set 
        {
            _currentState = value;
            _currentState.StartState();
        } 
    }
    public Animator anim;
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
        if(CurrentState != null)
            CurrentState.UpdateState();
    }
    public void FalseCoolDown()
    {
        slapState.FalseCooldown();
    }
    public void TrueCoolDown()
    {
        slapState.TrueCooldown();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trump")
        {
            CurrentState = climbFinishState;
            
            other.enabled = false;
        }
    }
    public void ChangeWalkState()
    {
        CurrentState = walkState;
        OnWalk?.Invoke();
    }
}
