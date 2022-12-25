using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbState : PlayerStateBase
{
    [SerializeField] private float speed, horizontalSpeed;
    public override void StartState()
    {
        Debug.Log("ClimbState");
    }

    public override void UpdateState()
    {
        Player.instance.transform.position += transform.up * Time.deltaTime * speed;
        Player.instance.transform.position += Vector3.forward * playerInput.horizontalInput * Time.deltaTime * horizontalSpeed;
    }
}
