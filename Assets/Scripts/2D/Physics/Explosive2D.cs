using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class Explosive2D : MonoBehaviour
    {
        public float explosiveForce = 10f;
        public float explosionRadius = 10f;

        public void Explode()
        {
            Vector2 explosionPos = transform.position;
            Collider2D[] colliders = Physics2D.OverlapCircleAll(explosionPos, explosionRadius);
            foreach (Collider2D hit in colliders)
            {
                Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();

                if (rb != null)
                    rb.AddForceAtPosition(Vector2.one  * explosiveForce, explosionPos, ForceMode2D.Impulse);
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, explosionRadius);
        }
    }
}
