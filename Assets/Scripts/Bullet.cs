using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigidbody;
    public float damage = 20f;

    private void Start()
    {
        rigidbody.velocity = transform.right * speed;
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Health enemy = other.collider.GetComponent<Health>();
        
        if (enemy)
        {
            if (!enemy.IsDead)
            {
                Debug.Log(enemy.IsDead);
                enemy.takeDamage(damage);

            }
        }
        
        Destroy(gameObject);
    }
}
