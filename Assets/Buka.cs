using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buka : MonoBehaviour
{
    private float timeLeft = 100;

    private bool left = true;

    public Transform m_leftSensor;
    public Transform m_rightSensor;
    private LayerMask m_WhatIsGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        bool hasLeft = Physics2D.OverlapCircle(m_leftSensor.position, 0.2f, m_WhatIsGround);
        bool hasRight = Physics2D.OverlapCircle(m_rightSensor.position, 0.2f, m_WhatIsGround);

        if (hasLeft || hasRight)
        {
            if (left && !hasLeft)
            {
                left = false;
            }
            else if (!left && !hasRight)
            {
                left = true;
            }
        }

        Rigidbody2D body = GetComponent<Rigidbody2D>();

        Vector2 targetVelocity;
        if (left)
        {
            targetVelocity = new Vector2(-10f, body.velocity.y);
        }
        else
        {
            targetVelocity = new Vector2(10f, body.velocity.y);
        }

        body.velocity = targetVelocity;
    }
}
