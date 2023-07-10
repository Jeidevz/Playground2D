using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDecreaserOnCollide2D : MonoBehaviour
{
    public float decreaseAmount = 1f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Durability decrease object collided with " + collision.collider.name);
        LivingObject2D livingObject = collision.gameObject.GetComponent<LivingObject2D>();

        if (livingObject)
        {
            livingObject.ChangeHealthByAmount(-decreaseAmount);
        }
    }
}
