using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // if (Mathf.Abs(moveHorizontal) > 0)
        // {
        //     rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);
        // }
        // if (Mathf.Abs(moveVertical) > 0)
        // {
        //     rb2d.velocity = new Vector2(rb2d.velocity.x, moveVertical * speed);
        // }
        
        Vector2 direction = new Vector2(moveHorizontal, moveVertical).normalized;
        rb2d.velocity = direction * speed;
    }

    void FixedUpdate()
    {
    }
}