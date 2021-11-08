using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    #region Public Values
    public float moveSpeed;
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer SpriteRenderer;

    #endregion

    #region Private Values
    private Vector2 movement;
    private bool TurnLeft;
    

    #endregion

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        TurnPlayer();
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        
    }

    private void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void TurnPlayer()
    {
        if (animator.GetFloat("Horizontal") < 0)
        {
            TurnLeft = true;
        }
        else if (animator.GetFloat("Horizontal") > 0)
        {
            TurnLeft = false;
        }

        if (TurnLeft)
        {
            SpriteRenderer.flipX = true;
        }
        else
        {
            SpriteRenderer.flipX = false;
        }
        
    }
}
