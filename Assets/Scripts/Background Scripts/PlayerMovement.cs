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
        [SerializeField] float seaLevelYPosition = 10;

        Vector3 playerInput;

        Gun[] guns;

        public float moveSpeed = 12;

        //bool moveUp;
        //bool moveDown;
        //bool moveLeft;
        //bool moveRight;
        //bool shoot;

        // Start is called before the first frame update

        void Start()
        {
            guns = GetComponentsInChildren<Gun>();
        }

        // Update is called once per frame
        void Update()
        {

            //this just makes it stop at a certain y position (basically Mathf.Clamp(), but didn't work for some reason).
            if (transform.position.y > seaLevelYPosition)
            {
                transform.position = new Vector3(transform.position.x, seaLevelYPosition, transform.position.z);
            }

            //Simplified input system. Horizontal is the W & S key, up & down key, joystick up & down. Vertical is the A & D key, Left & Right key, joystick Left & Right.
            playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

            #region Matthew Hamm's Inputs
            //Movement Keys
            //moveUp = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
            //moveDown = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
            //moveLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
            //moveRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

            //Shoot Key
            //GetKeyDown - Only shoot when the key is pressed.
            //GetKey - Holding down the key will keep shooting.
            #endregion Matthew Hamm's Inputs
        }

        private void FixedUpdate()
        {

            //I know what you were doing and it was smart, but here is a more compact version. The ".normalized" on the playerInput does what you were doing below.
            transform.position = transform.position + playerInput.normalized * moveSpeed * Time.fixedDeltaTime;

            #region Matthew Hamm's Speed Normalization
            //Vector3 pos = transform.position;

            //float moveAmout = moveSpeed * Time.fixedDeltaTime;
            //Vector3 move = Vector3.zero;

            //if (moveUp)
            //{
            //    move.y += moveAmout;
            //}

            //if (moveDown)
            //{
            //    move.y -= moveAmout;
            //}

            //if (moveLeft)
            //{
            //    move.x -= moveAmout;
            //}

            //if (moveRight)
            //{
            //    move.x += moveAmout;
            //}

            ////Stops the sub moving faster on the diagonal
            //float moveMagnitude = Mathf.Sqrt(move.x * move.x + move.y * move .y);
            //if (moveMagnitude > moveAmout)
            //{
            //    float ratio = moveAmout / moveMagnitude;
            //    move *= ratio;
            //}

            //pos += move;


            //Stops the sub from moving outside of the camera

            //transform.position = pos;
            #endregion Matthew Hamm's Speed Normalization
        }
    }
}