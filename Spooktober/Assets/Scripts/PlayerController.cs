using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    public float jumpForce;
    public float speed;
    public float jumpTime;

    [Header("Check if Grounded")]
    public Transform groundPos;
    public float checkRadius;
    //public LayerMask whatIsGround;
    public GroundCheck groundCheck;

    private float jumpTimeCounter;
    private Rigidbody2D rb;
    private bool isJumping;
    private bool doubleJump;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {

        if(isGrounded() == true && Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("TakeOff");
            isJumping = true;
            jumpTimeCounter = jumpForce;
            rb.velocity = Vector2.up * jumpForce;
        }

        if(isGrounded() == true)
        {
            doubleJump = false;
            anim.SetBool("isJumping", false);
        }
        else
        {
            anim.SetBool("isJumping", true);
        }
      
        //if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        //{

        //    isJumping = true;
        //    jumpTimeCounter = jumpTime;
        //    rb.velocity = Vector2.up * jumpForce;
        //}

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if(jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        if(isGrounded() == false && doubleJump == false && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            doubleJump = true;
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    private bool isGrounded()
    {
        return groundCheck.isGrounded;
    }

}