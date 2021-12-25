using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D col;

    [SerializeField] private LayerMask jumpground;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>(); 
    }

    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2( dirX * 7f, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && isGrounded()){
            GetComponent<Rigidbody2D>().velocity = new Vector2(rb.velocity.x,14);
        }    
    }

    private bool isGrounded()
    {
       return Physics2D.BoxCast(col.bounds.center, col.bounds.size, 0f, Vector2.down, .1f, jumpground);
    }
}
