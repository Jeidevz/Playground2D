using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class InputTests : MonoBehaviour
    {
        public CameraShaker2D cameraShaker2D;
        public float shakeDuration = 0.3f;
        public float shakeMagnitude = 0.1f;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine(cameraShaker2D.Shake(shakeDuration, shakeMagnitude));
                Debug.Log("Mouse0 pressed");
            }
        }
    }
}