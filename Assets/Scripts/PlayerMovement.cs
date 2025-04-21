using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float move; //walk left-right
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce; //jump
    private bool isJumping;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //walk left-right
        move = Input.GetAxis("Horizontal");
        rb2d.linearVelocity = new Vector2(move * speed, rb2d.linearVelocity.y);
        
        //jump
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, jumpForce));
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }   
}
