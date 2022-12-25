using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerInput input;

    private void Update()
    {
        input.horizontalInput = Input.GetAxis("Horizontal");
        input.isClick = Input.GetMouseButtonDown(0);
        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    if (touch.phase == TouchPhase.Began)
        //    {

        //    }
        //    if (touch.phase == TouchPhase.Moved)
        //    {
        //        input.horizontalInput = touch.deltaPosition.normalized.x;
        //    }
        //    else
        //    {
        //        input.horizontalInput = 0;
        //    }
        //}
    }
}
