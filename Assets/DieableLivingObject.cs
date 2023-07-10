using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieableLivingObject : MonoBehaviour
{
    public GameObject targetObject;
    public LivingObject2D livingObject;
    // Update is called once per frame
    void Update()
    {
        if(livingObject.HasHealthReachedToZero())
        {
            Destroy(targetObject);
        }



    }
}
