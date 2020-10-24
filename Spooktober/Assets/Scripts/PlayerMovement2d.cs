using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2d : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 mv;

    void Start()
    {
        Debug.Log("Hello Myself");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mv * Time.fixedDeltaTime);
    }
        
}