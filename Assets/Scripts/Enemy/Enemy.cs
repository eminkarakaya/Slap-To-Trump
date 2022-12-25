using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    public static Enemy instance;
    private void Awake()
    {
        instance = this;
    }
}
