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
    private float jump = 5f;

    void Start()
    {
        Debug.Log("Hello Myself");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetInput();

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        
    }

    public void GetInput()
    {
        horizontal = Input.GetAxis("Horizontal");

        move = new Vector3(horizontal, 0f, 0f);

    }

    private void FixedUpdate()
    {
        rb.position += move * Time.deltaTime * speed;
    }

    public void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
        
}