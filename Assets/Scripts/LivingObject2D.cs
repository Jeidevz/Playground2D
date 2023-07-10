using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingObject2D : MonoBehaviour
{
    public Health health;

    public bool HasHealthReachedToZero()
    {
        return health.amount <= 0;
    }

    public void ChangeHealthByAmount(float amount)
    {
        health.amount += amount;
    }
}
