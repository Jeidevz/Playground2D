using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTest2D : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation *= Quaternion.Euler(0, 0, speed * Time.deltaTime);
    }
}
