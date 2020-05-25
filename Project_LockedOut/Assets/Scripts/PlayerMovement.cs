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
    public bool move;
    

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (move)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal");
            verticalMove = Input.GetAxisRaw("Vertical");
        }
        if (!move)
        {
            horizontalMove = 0;
            verticalMove = 0;
        }

       
            animator.SetFloat("SpeedH", horizontalMove);
            animator.SetFloat("SpeedV", verticalMove);

    }

    private void FixedUpdate()
    {
       // if (move)
       // {
            Vector2 position = rigidbody2d.position;
            position.x = position.x + 3.0f * horizontalMove * Time.deltaTime;
            position.y = position.y + 3.0f * verticalMove * Time.deltaTime;

            rigidbody2d.MovePosition(position);
       // }
        
    }
}
