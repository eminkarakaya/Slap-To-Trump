using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class LookAtTower : MonoBehaviour
{
    [SerializeField] private Transform towerTransform;

    private void Update()
    {
        Vector3 towerPos = new Vector3(towerTransform.position.x, transform.position.y, towerTransform.position.z);
        transform.DOLookAt(towerPos,.2f);
    }
}
