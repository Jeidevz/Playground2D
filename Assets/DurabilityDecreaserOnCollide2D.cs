using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class DurabilityDecreaserOnCollide2D : MonoBehaviour
{
    public float decreaseAmount = 1f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Durability decrease object collided with " + collision.collider.name);
        DurableObject durableObject = collision.gameObject.GetComponent<DurableObject>();

        if(durableObject)
        {
            durableObject.ChangeDurabilityByAmount(-decreaseAmount);
        }
    }
}
