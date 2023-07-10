using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class TopDownCharacterMovement2D : MonoBehaviour
    {
        public float movementSpeed = 1f;

        // Update is called once per frame
        void Update()
        {
            float dt = Time.deltaTime;

            if (Input.anyKey)
            {
                float vertical = Input.GetAxis("Vertical");
                float horizontal = Input.GetAxis("Horizontal");

                Vector3 direction = new Vector3(horizontal, vertical, 0);
                transform.position += direction * movementSpeed * dt;
            }

        }
    }

}