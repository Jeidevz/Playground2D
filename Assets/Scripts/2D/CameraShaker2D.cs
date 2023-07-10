using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class CameraShaker2D : MonoBehaviour
    {
        public IEnumerator Shake(float duration, float magnitude)
        {
            Vector3 originalPosition = new Vector3(0, 0, 0);
            float elapsedTime = 0f;

            while (elapsedTime < duration)
            {
                float x = Random.Range(-1f, 1f) * magnitude;
                float y = Random.Range(-1f, 1f) * magnitude;

                transform.localPosition = new Vector3(x, y, originalPosition.z);
                elapsedTime += Time.deltaTime;
                //Debug.Log("Shaking");

                yield return null;
            }

            transform.localPosition = originalPosition;
        }


    }
}
