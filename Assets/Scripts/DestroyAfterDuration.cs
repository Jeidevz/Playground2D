using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class DestroyAfterDuration : MonoBehaviour
    {
        public GameObject targetObject;
        public float delay = 0f;
        // Start is called before the first frame update
        void Start()
        {
            if (targetObject)
            {
                Destroy(targetObject, delay);
            }
            else
            {
                Destroy(gameObject, delay);
            }
        }
    }
}