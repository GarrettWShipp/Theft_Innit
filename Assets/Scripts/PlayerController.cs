using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    private Rigidbody2D rb; //Getting the rigidbody

    public float speed = 2; //Movement Speed value
    public float jump = 14f; //Jump value
    public Animator anmi;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Automatically gathers the component off of the object the script is on
    }
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal"); //Getting the direction of the object
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y); //Moving in that direction using A or D

        anmi.SetFloat("Direction", Input.GetAxisRaw("Horizontal"));

        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(2.95f, 0.45f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump); //Movement for up
            
        } //End of Jump
    }// End of Update
    
    
} //End of Class

