using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CameraScript : MonoBehaviour
{
    [SerializeField] private Transform cameraFightPlace;
    private void OnEnable()
    {
        Player.OnWalk += CameraFightAnimation;
    }
    private void OnDisable()
    {
        Player.OnWalk -= CameraFightAnimation;
    }
    public void CameraFightAnimation()
    {
        transform.DOMove(cameraFightPlace.position, 1f);
        transform.DORotate(cameraFightPlace.rotation.eulerAngles, 1f);
    }
}
