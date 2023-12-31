using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed = 5f;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rb2d.velocity = new Vector2(vertical * speed , rb2d.velocity.y);
        
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.x);


    }
}
