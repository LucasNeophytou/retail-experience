using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagScript : MonoBehaviour
{
    
    public bool bagIsEmpty;
    public List<GameObject> itemsInBag = new List<GameObject>();
    public bool bagIsClosed;
    public bool bagOverCustomer;
    public bool bagOverBags;


    void Awake () {

        bagIsEmpty = true;
    }

    void OnTriggerStay2D (Collider2D other) {

        if (other.tag == "Draggable") {

            bagIsEmpty = false;
        }
    }

    void OnTriggerEnter2D (Collider2D other) {

        if (other.tag == "Draggable") {

            itemsInBag.Add(other.gameObject);
        }

        if (other.tag == "Customer") {

            bagOverCustomer = true;
        }

        
    }

    void OnTriggerExit2D (Collider2D other) {

        if (other.tag == "Draggable") {

            bagIsEmpty = true;
            itemsInBag.Remove(other.gameObject);
        }

        if (other.tag == "Customer") {

            bagOverCustomer = false;
        }

        
    }

    void OnMouseUp () {

        if (bagOverCustomer) {

            DeliverItems();
        }
    }

    void OnMouseOver () {

        if (Input.GetKeyDown("mouse 1")) {

            if (bagIsEmpty) {

                Destroy(gameObject);
            }
        }
    }

    void DeliverItems () {

        
    }




}
