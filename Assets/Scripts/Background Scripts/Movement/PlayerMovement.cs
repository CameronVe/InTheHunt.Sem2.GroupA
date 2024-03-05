using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Matthew;

namespace Matthew
{
    ///<summary>
    ///script for the player sub.
    ///Author: Matthew Hamm, Modified by Tristan Mckay
    ///WASD & Arrow Keys for movement
    ///</summary>

    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed = 5f;
        [SerializeField] private float TopPositionY = 9f;
        [SerializeField] private float BottomPositionY = 1f;

        private Transform transform;
        private Vector3 moveVector;
        private Rigidbody rigidbody;

        void Start()
        {
            //Cache transform and initalise moveVector
            transform = this.GetComponent<Transform>();
            Vector3 moveVector = Vector3.zero;

            rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            //MoveUsingTransform();
        }
        void FixedUpdate()
        {
            MoveUsingRigidbody();
        }

        /// <summary>
        /// Move the player using common keys (it also allows up and down movement too)
        /// </summary>
        private void MoveUsingRigidbody()
        {
            moveVector = Vector3.zero;

            float xMovement = Input.GetAxis("Horizontal");
            float yMovement = Input.GetAxis("Vertical");

            moveVector.x = xMovement;

            if (transform.position.y < TopPositionY && yMovement > 0)
            {
                moveVector.y = yMovement;
            }

            if (transform.position.y > BottomPositionY && yMovement < 0)
            {
                moveVector.y = yMovement;
            }


            rigidbody.velocity = Vector3.zero;
            rigidbody.MovePosition(transform.position + moveVector.normalized * moveSpeed * Time.fixedDeltaTime);
        }
    }
}