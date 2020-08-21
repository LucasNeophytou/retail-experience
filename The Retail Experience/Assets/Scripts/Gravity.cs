using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float fallMultiplier;
    public float gravityMultiplier;
    public float dragMultiplier;

    Rigidbody2D rb;
    public static Gravity instance;

    void Awake () {

        rb = GetComponent<Rigidbody2D> ();
        instance = this;
    }
    
    void FixedUpdate () {

        if (rb.velocity.y < 0) {

            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        
        
        
        if (rb.velocity.y > 0) {

            rb.velocity += Vector2.up * Physics2D.gravity.y * (gravityMultiplier - 1) * Time.deltaTime;
            Debug.Log(rb.velocity);

        }

        // if (rb.velocity.x < 0) {

            // rb.velocity += Vector2.right * (dragMultiplier - 1) * Time.deltaTime;
        // }
    }

    
}
