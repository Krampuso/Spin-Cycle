using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    float speedX;
    float speedY;
    Rigidbody2D rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         Move();
         Flip();
    }

    void Move()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.velocity = new Vector2(speedX, speedY);
    }

    void Flip()
    {
        /*if (Keyboard.current.downAKey.wasPressedThisFrame)
        {
            transform.Rotate(0,180,0);
        }*/
    }
}
