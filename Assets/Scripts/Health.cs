using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float healthPoints = 50;
    private Boolean isDead;

    public void takeDamage(float damage)
    {
        healthPoints -= damage;

        if (healthPoints < 0)
            isDead = true;
    }

    public void Update()
    {
        if (isDead) 
            Destroy(gameObject);
    }

    public bool IsDead
    {
        get { return isDead; }
    }
}
