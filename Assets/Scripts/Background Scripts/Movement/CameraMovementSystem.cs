using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;

public class CameraMovementSystem : MonoBehaviour
{
    [SerializeField] GameObject objectInCart;

    [SerializeField]
    private CinemachineSplineCart cart;

    [SerializeField]
    SplineAutoDolly dolly;

    [SerializeField] float LowestPosition;
    [SerializeField] float longestPosition;


    private void Start()
    {
        dolly = cart.AutomaticDolly;
    }

    private void Update()
    {
        if (cart.SplinePosition < 0.11f)
        {
            cart.SplinePosition = 0.1f;
        }
    }
}
