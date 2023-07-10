using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class DestroyOnCollide2D : MonoBehaviour
    {
        public GameObject targetObject;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (targetObject)
            {
                Destroy(targetObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}