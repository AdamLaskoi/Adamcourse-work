using CartoonFX;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


class PlayerMovment_rev2 : MonoBehaviour
{
    [SerializeField] float accelleration = 5;
    [SerializeField] float AirResistant = 1;
    [SerializeField] float jumpForce = 4f;
    

    Rigidbody2D playerRD;
    Vector2 velocity;
    void Start()
    {
        playerRD = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {
        bool jump = Input.GetKeyDown(KeyCode.Space);

        if (jump)
        {
            playerRD.velocity = Vector2.up * jumpForce;
            
            
        }
    }

    

    void FixedUpdate()
    {

        bool Right = Input.GetKey(KeyCode.D);
        bool Left = Input.GetKey(KeyCode.A);


        if (Right)
        {
            velocity += (Vector2)transform.right * (accelleration * Time.fixedDeltaTime);
        }
        if (Left)
        {
            velocity -= (Vector2)transform.right * (accelleration * Time.fixedDeltaTime);
        }


        transform.position += (Vector3)(velocity * Time.fixedDeltaTime);

        velocity *= 1f - (AirResistant * Time.fixedDeltaTime);

        


    }
    

  


}
