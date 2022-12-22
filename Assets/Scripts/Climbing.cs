using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour
{
    [SerializeField] private PlayerInput input;
    [SerializeField] private float r, speed,currentAngle;

    private void OnDrawGizmos()
    {
        //Gizmos.DrawWireSphere(Vector3.zero , r);
    }
    private void Update()
    {
        //transform.position += transform.up*Time.deltaTime*speed;
        HorizontalMove();
        transform.position = AngleTo(currentAngle);
        
    }
    private void HorizontalMove()
    {
        currentAngle += input.horizontalInput;
    }
    private Vector3 AngleTo(float angle)
    {
        float x = r * Mathf.Cos(angle*Mathf.Deg2Rad) ;
        float z = r * Mathf.Sin(angle*Mathf.Deg2Rad) ;
        return new Vector3(x, transform.position.y, z);
    }
    
}
