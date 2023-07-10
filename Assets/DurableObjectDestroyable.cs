using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DurableObjectDestroyable : MonoBehaviour
{
    public GameObject targetDestroyObject;
    public DurableObject durability;
    private void Update()
    {
        if(durability.HasDurabilityReachedZero())
        {
            Destroy(targetDestroyObject);
        }
    }
}
