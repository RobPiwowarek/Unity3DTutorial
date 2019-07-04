using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigidbody;


    private void Start()
    {
        rigidbody.velocity = transform.right * speed;
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        Destroy(gameObject);
    }
}
