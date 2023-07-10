using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JDevs.Playground2D
{
    public class ExplodeOnTimer2D : MonoBehaviour
    {
        public Explosive2D explosive;
        public float duration;
        public bool destroyAfterExplosion;

        void Start()
        {
            ExecuteExplosionOnTimer();
        }

        void ExecuteExplosionOnTimer()
        {
            StartCoroutine(ExplodeOnTimer(duration, explosive));
        }

        IEnumerator ExplodeOnTimer(float duration, Explosive2D exploder)
        {
            float elapsedTime = 0f;
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            exploder.Explode();
            if(destroyAfterExplosion)
            {
                Destroy(gameObject);
            }
        }
    }
}