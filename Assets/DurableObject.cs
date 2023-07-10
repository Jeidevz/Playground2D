using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DurableObject : MonoBehaviour
{
    public float durability = 10f;

    public bool HasDurabilityReachedZero()
    {
        return (durability <= 0);
    }

    public void ChangeDurabilityByAmount(float amount)
    {
        durability += amount;
    }
}
