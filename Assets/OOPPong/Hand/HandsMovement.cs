using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong.Movement
{
    public class HandsMovement : Hands
    {

        float value=0.07f;
        private void Update()
        {

            HandMovement();



        }


        void HandMovement()
        {
           
            if (Input.GetKey(KeyCode.W))
            {
                ball.transform.position += new Vector3(0, value, 0); 
            }
            if (Input.GetKey(KeyCode.S))
            {
                ball.transform.position += new Vector3(0, -value, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                ball2.transform.position += new Vector3(0, value, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                ball2.transform.position += new Vector3(0, -value, 0);
            }



        }
    }
}