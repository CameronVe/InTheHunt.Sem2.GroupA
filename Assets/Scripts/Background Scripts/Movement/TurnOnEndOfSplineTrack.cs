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

        [SerializeField] GameObject bomb;

        [SerializeField]
        private CinemachineSplineCart cart;

        [SerializeField]
        SplineAutoDolly dolly;

        // What axis the object will turn on
        // (as the turn point may vary)

        [SerializeField] bool isTurnX = false;
        [SerializeField] bool isTurnY = true;
        [SerializeField] bool isTurnZ = false;
        [SerializeField] bool dropsBombs = false;

        [SerializeField] float secondsToTurn = 3;

        // The max length before the right turn

        [SerializeField] float splineMaxBeforeTurn;
        [SerializeField] float splineMinBeforeTurn = 0;

        // In this case this is forward

        [SerializeField] float cartSpeedLeft;

        // In this case this is backwards

        [SerializeField] float cartSpeedRight;
        //[SerializeField] float BombSpawnPosition;

        float timer = 0;
        [SerializeField] float SpawnBombTime = 7.5f;

        private void Start()
        {
            dolly = cart.AutomaticDolly;
        }

        private void Update()
        {
            TurnAxis(isTurnX, objectInCart.transform.localRotation.x, -180, 0, 0, secondsToTurn);
            TurnAxis(isTurnY, objectInCart.transform.localRotation.y, 0, -180, 0, secondsToTurn);
            TurnAxis(isTurnZ, objectInCart.transform.localRotation.z, 0, 0, -180, secondsToTurn);

            if (dropsBombs)
            {
                if (timer > SpawnBombTime)
                {
                    Instantiate(bomb.gameObject, transform.position, Quaternion.identity);
                    timer = 0;
                }
                else
                {
                    timer += Time.deltaTime;
                }
            }
        }

        private void TurnAxis(bool check, float transformAxis, float x, float y, float z, float seconds)
        {
            float cartPosition = cart.SplinePosition;

            if (check == true)
            {
                // Gets The speed of the spline dolly

                if (dolly.Enabled && dolly.Method is SplineAutoDolly.FixedSpeed fixedSpeedMethod)
                {
                    // Checks the position of the cart

                    if (cartPosition <= splineMinBeforeTurn)
                    {
                        // This increments the float until the desired float is met (it's a turn animation)

                        DOTween.To(() => objectInCart.transform.localRotation, newPosition => objectInCart.transform.localRotation = newPosition, new Vector3(0, 0, 0), seconds);

                        // Checks how fare we are in the turn

                        if (Mathf.Abs(transformAxis) < 0.14) // 14% of 180 degrees
                        {
                            // Sets the speed of the cart to the set value

                            fixedSpeedMethod.Speed = cartSpeedLeft;
                        }
                    }

                    if (cartPosition >= splineMaxBeforeTurn)
                    {
                        // This increments the float until the desired float is met (it's a turn animation)

                        DOTween.To(() => objectInCart.transform.localRotation, newPosition => objectInCart.transform.localRotation = newPosition, new Vector3(x, y, z), seconds);

                        // Checks how fare we are in the turn

                        if (Mathf.Abs(transformAxis) > 0.96) // 96% of 180 degrees
                        {
                            // Sets the speed of the cart to the set value

                            fixedSpeedMethod.Speed = cartSpeedRight;
                        }
                    }
                }
            }
        }

        
    }
}

