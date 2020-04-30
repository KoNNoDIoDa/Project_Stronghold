using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rigidbody2d;
    public float horizontalMove;
    public float verticalMove;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        animator.SetFloat("Speed", math.abs(horizontalMove));

        verticalMove = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 3.0f * horizontalMove * Time.deltaTime;
        position.y = position.y + 3.0f * verticalMove * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
}
