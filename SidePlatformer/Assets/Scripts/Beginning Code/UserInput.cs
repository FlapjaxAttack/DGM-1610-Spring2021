using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    public Rigidbody2D ballRigidbody2D;
    public float speed = 3f;
    public float jumpForce = 300f;
   
    public Vector2 direction;
    public Vector2 ydirection;
    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * speed;
        ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
        
        if (Input.GetButtonDown("Jump"))
        {
            ydirection.y = jumpForce;
            ballRigidbody2D.AddForce(ydirection, ForceMode2D.Force);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
