using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class Timer : MonoBehaviour
    {
        private float duration = 0f;
        private bool isFinished = false;

        public Timer(float duration)
        {
            this.duration = duration;
        }

        public void StartTimer()
        {
            StartCoroutine(RunTimer(duration));
        }

        public bool IsFinished()
        {
            return isFinished;
        }

        IEnumerator RunTimer(float duration)
        {
            float elapsedTime = 0;

            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;

                yield return null;
            }

            isFinished = true;
        }
    }
}