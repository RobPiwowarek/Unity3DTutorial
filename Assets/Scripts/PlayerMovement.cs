using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller; // publiczne sa widoczne w unity

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("logowac mozna tak");
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;   // lewo -1 1 prawo 
        if (Input.GetButtonDown("Jump")) // czemu jump? edit -> project settings -> input
        {
            jump = true;
        }
   
    }

    // called fixed amount of time per second, dedicated to physics
    // generally for movement
    void FixedUpdate()
    {
        // fixed delta time to ile czasu minelo od ostatniego czasu kiedy ta funkcja zostala wywolana, wiec daje to staly speed niezaleznie od tego ile razy to jest wolane
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    
}
