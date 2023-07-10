using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class ProjectileFiringPoint2D : MonoBehaviour
    {
        public Transform shootTargetDirection;

        public Vector2 GetShootDirection()
        {
            Vector3 direction = transform.position - shootTargetDirection.position;
            Vector2 shootingDirection = new Vector2(direction.x, direction.y);
            return shootingDirection;
        }

        public Vector3 GetFiringPosition()
        {
            return transform.position;
        }
    }
}