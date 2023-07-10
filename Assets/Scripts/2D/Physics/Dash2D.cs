using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash2D : MonoBehaviour
{
    public bool dashAvailable = true;
    public int dashCountMax = 1;
    public int dashCount;
    public float cooldown = 2f;
    public KeyCode dashKey;
    public Vector2 dashDirection;
    public float force = 200;
    public Rigidbody2D body;

    private float cooldownCountdown = 0;

    // Start is called before the first frame update
    void Start()
    {
        dashCount = dashCountMax;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(dashKey) && dashCount > 0)
        {
            GetInputAxis(ref dashDirection);
            Dash(dashDirection);
        }

        if(dashCount < dashCountMax)
        {
            RefreshingDashCount();
        }
    }

    private void RefreshingDashCount()
    {
        if(cooldownCountdown < cooldown)
        {
            cooldownCountdown += Time.deltaTime;
        }
        else
        {
            cooldownCountdown = 0;
            dashCount++;
        }
    }

    void Dash(Vector2 direction)
    {
        body.AddForce(direction * force, ForceMode2D.Impulse);
        dashCount--;
    }

    void GetInputAxis(ref Vector2 outAxis)
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        outAxis.Set(horizontal, vertical);
    }
}
