using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class Jump2D : MonoBehaviour
    {
        public bool canJump = true;
        public int jumpCountMax = 2;
        public int jumpCount = 1;
        public KeyCode jumpKey;
        public float force = 120f;
        public Rigidbody2D body;

        // Update is called once per frame
        void Update()
        {
            if (canJump && Input.GetKeyDown(jumpKey) && jumpCount > 0)
            {
                jump();
            }
        }

        void jump()
        {
            body.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            jumpCount--;
        }

        void jumpCountReset()
        {
            jumpCount = jumpCountMax;
        }

        void jumpUpgrade(int upgradeAmount)
        {
            jumpCountMax += upgradeAmount;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Collision enter");
            if (collision.gameObject.tag == "Floor")
            {
                jumpCountReset();
                Debug.Log("Floor hit");
            }
        }
    }
}
