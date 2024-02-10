using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;
using Unity.Cinemachine;
using DG.Tweening;
using Unity.VisualScripting;
using TMPro;

namespace Tristan
{
	/// <summary>
	/// Author: Tristan McKay
	/// Description: This script turns the object on a spline track when it reaches the end
	///				 and then sets the carts speed to a negative or a positve depending on
	///				 the direction.
	/// </summary>

	public class TurnOnEndOfSplineTrack : MonoBehaviour
    {
        [SerializeField] GameObject objectInCart;

        [SerializeField]
        private CinemachineSplineCart cart;

        [SerializeField]
        SplineAutoDolly dolly;

        [SerializeField] bool isTurnX = false;
        [SerializeField] bool isTurnY = true;
        [SerializeField] bool isTurnZ = false;
        [SerializeField] float secondsToTurn = 3;
        [SerializeField] float splineMaxBeforeTurn;
        [SerializeField] float cartSpeedLeft;
        [SerializeField] float cartSpeedRight;

        private void Start()
        {
            dolly = cart.AutomaticDolly;
        }

        private void Update()
        {
            TurnAxis(isTurnX, objectInCart.transform.localRotation.x, -180, 0, 0, secondsToTurn);
            TurnAxis(isTurnY, objectInCart.transform.localRotation.y, 0, -180, 0, secondsToTurn);
            TurnAxis(isTurnZ, objectInCart.transform.localRotation.z, 0, 0, -180, secondsToTurn);
        }
        private void TurnAxis(bool check, float transformAxis, float x, float y, float z, float seconds)
        {
            float cartPosition = cart.SplinePosition;

            if (check == true)
            {
                if (dolly.Enabled && dolly.Method is SplineAutoDolly.FixedSpeed fixedSpeedMethod)
                {
                    if (cartPosition == 0)
                    {
                        DOTween.To(() => objectInCart.transform.localRotation, newPosition => objectInCart.transform.localRotation = newPosition, new Vector3(0, 0, 0), seconds);

                        if (Mathf.Abs(transformAxis) < 0.14) // 14% of 180 degrees
                        {
                            fixedSpeedMethod.Speed = cartSpeedLeft;
                        }
                    }

                    if (cartPosition >= splineMaxBeforeTurn)
                    {
                        DOTween.To(() => objectInCart.transform.localRotation, newPosition => objectInCart.transform.localRotation = newPosition, new Vector3(x, y, z), seconds);

                        if (Mathf.Abs(transformAxis) > 0.96) // 96% of 180 degrees
                        {
                            fixedSpeedMethod.Speed = cartSpeedRight;
                        }
                    }
                }
            }
        }
    }
}

