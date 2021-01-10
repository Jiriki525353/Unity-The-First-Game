using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float PlayerMoveSpeed;
    public Rigidbody2D rb;
    private Vector2 MoveDirection;

    void Start()
    {
        
    }

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move(); 
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        MoveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(MoveDirection.x * PlayerMoveSpeed, MoveDirection.y * PlayerMoveSpeed);
    }
}
