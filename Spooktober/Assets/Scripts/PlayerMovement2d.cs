using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2d : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private Rigidbody2D rb;
    private Vector2 move;

    private float horizontal;
    private float vertical;
    private float jump;

    void Start()
    {
        Debug.Log("Hello Myself");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    public void GetInput()
    {
        horizontal = Input.GetAxis("Horizontal");
        jump = Input.GetAxis("Jump");

        move = new Vector2(horizontal, 0);

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }
        
}