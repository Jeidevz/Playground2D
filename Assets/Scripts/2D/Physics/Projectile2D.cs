using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class Projectile2D : MonoBehaviour
    {
        public Vector2 projectileDirection;
        public float force = 30f;
        public Rigidbody2D rg;

        void Start()
        {
            projectileDirection = transform.right;
            rg.AddForce(projectileDirection.normalized * force, ForceMode2D.Impulse);
        }

        public void SetFiringDirection(Vector2 direction)
        {
            projectileDirection = direction;
        }
    }
}