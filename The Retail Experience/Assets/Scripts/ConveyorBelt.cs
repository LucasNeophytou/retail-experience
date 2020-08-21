using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    private SurfaceEffector2D effector;
    public int beltSpeed;

    void Awake () {

        effector = GetComponent<SurfaceEffector2D>();
        effector.speed = beltSpeed;
    }

    void OnTriggerEnter2D (Collider2D other) {

        if (other.tag == "Draggable") {

            effector.speed = 0;
        } 
    }

    void OnTriggerStay2D (Collider2D other) {

        if (other.tag == "Draggable") {

            effector.speed = 0;
        } 
    }

    void OnTriggerExit2D (Collider2D other) {

        if (other.tag == "Draggable") {

            effector.speed = beltSpeed;
        } 
    }
    
}
