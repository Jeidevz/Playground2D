using UnityEngine;
using System.Collections;

namespace JDevs.Playground2D
{
    public class CameraFollow2D : MonoBehaviour
    {

        public float dampTime = 0.15f;
        private Vector3 velocity = Vector3.zero;
        public Transform target;
        //public Camera cam;

        // Update is called once per frame
        void Update()
        {
            if (target)
            {
                //Vector3 point = cam.WorldToViewportPoint(target.position);
                //Vector3 delta = target.position - cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
                //Vector3 destination = transform.position + delta;
                Vector3 destination = new Vector3(target.position.x, target.position.y, transform.position.z);
                transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
            }

        }
    }
}