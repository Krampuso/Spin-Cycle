using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();     
        rb.velocity = transform.up * speed; // when bullet spawns, moves to the right * speed
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
