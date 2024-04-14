using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 5f; //how fast player moves
    private bool isFacingRight = true; //checks if players is facing left or right

    [SerializeField] private Rigidbody2D rb; //show on unity for referencing 
    [SerializeField] private Transform groundCheck; //show on unity for referencing 
    [SerializeField] private LayerMask groundLayer; //show on unity for referencing 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void Flip() //method to flip the player 
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
