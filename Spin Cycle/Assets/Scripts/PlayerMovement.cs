using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private Vector2 movementInput;
    public Rigidbody2D rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");
        movementInput = movementInput.normalized;
    }
    
    void FixedUpdate()
    {
       rb.velocity = movementInput * moveSpeed;

       rb.velocity = Vector2.ClampMagnitude(rb.velocity, moveSpeed);
    }

}
