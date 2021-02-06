using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    public Rigidbody2D ballRigidbody2D;
    public Vector2 direction;
    public Vector2 ydirection;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ballRigidbody2D.AddForce(-direction, ForceMode2D.Force);
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ballRigidbody2D.AddForce(ydirection, ForceMode2D.Force);
        }
    }
}
