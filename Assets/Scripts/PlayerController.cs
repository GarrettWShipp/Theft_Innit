using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    private Rigidbody2D rb; //Getting the rigidbody

    public float speed = 2; //Movement Speed value
    public float jump = 14f; //Jump value

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Automatically gathers the component off of the object the script is on
    }
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal"); //Getting the direction of the object
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y); //Moving in that direction using A or D


        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump); //Movement for up
        } //End of Jump


    }// End of Update
} //End of Class

