using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Matthew;

namespace Matthew
{
    ///<summary>
    ///Author: Matthew Hamm, Modified by Tristan Mckay
    ///Script for bullet Speed and lifetime.
    ///Place this script on the bullet prefab.
    /// </summary>
    
    public class Bullet : MonoBehaviour
    {
        public Vector2 direction = new Vector2(1, 0); // Direction in which the bullet will move
        public float speed = 8; // Speed of the bullet
        public Vector2 velocity; // Current velocity of the bullet
        public float timeOfDeletionInSeconds = 2;

        [SerializeField] bool top;
        [SerializeField] bool forward;
        [SerializeField] bool Back;
        [SerializeField] bool bottom;

        // Start is called before the first frame update
        void Start()
        {
            // Destroying the bullet after # seconds to prevent the player from killing enemies off screen.
            Destroy(gameObject, timeOfDeletionInSeconds);
        }

        // Update is called once per frame
        void Update()
        {
            // Calculate the velocity based on the given direction and speed
            velocity = direction * speed;
        }

        private void FixedUpdate()
        {
            if (top == true)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            if (forward == true)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            if (Back == true)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }

            if (bottom == true)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
}