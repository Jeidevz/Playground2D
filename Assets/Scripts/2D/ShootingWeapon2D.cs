using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class ShootingWeapon2D : MonoBehaviour
    {
        public GameObject projectilePrefab;
        public ProjectileFiringPoint2D projectileFiringPoint;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                shoot();
            }
        }
        public void shoot()
        {
            Vector2 shootDirection = projectileFiringPoint.GetShootDirection();
            Vector3 firingPoint = projectileFiringPoint.GetFiringPosition();
            Instantiate(projectilePrefab, firingPoint, transform.rotation);
        }



    }

}