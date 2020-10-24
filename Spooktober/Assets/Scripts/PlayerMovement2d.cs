﻿using System.Collections;
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
        Vector2 mi = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        mv = mi.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mv * Time.fixedDeltaTime);
    }
}