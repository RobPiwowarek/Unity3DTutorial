using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    private Boolean fire = false;
    
    // Start is called before the first frame update
    private void FixedUpdate()
    {

        if (fire)
        {
            Transform obj = Instantiate(bullet, firePoint.position, firePoint.rotation).GetComponent<Transform>();
        }
        
            
        fire = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire = true;
        }
    }
}
