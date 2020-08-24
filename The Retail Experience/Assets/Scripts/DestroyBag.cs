using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBag : MonoBehaviour
{
    
    public bool bagIsEmpty;
    public List<GameObject> itemsInBag = new List<GameObject>();
    public GameObject handle;
    public bool bagIsClosed;
    public Vector2 initialPosition;
    public Vector2 mousePosition;
    private float deltaX, deltaY;
    public bool bagOverCustomer;
    //private PolygonCollider2D col;
    private Rigidbody2D rgb;
    private BoxCollider2D boxCol;

    void Awake () {

        bagIsEmpty = true;
        initialPosition = transform.position;
        //col = GetComponent<PolygonCollider2D>();
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
            //Debug.Log("This is executing");
            itemsInBag.Remove(other.gameObject);
        }

        if (other.tag == "Customer") {

            bagOverCustomer = false;
        }

        if (other.tag == "Packed") {

            other.tag = "Draggable";
        }
        
    }

    void OnMouseDown () {

        if (bagIsClosed) {

            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
            
    }

    void OnMouseDrag () {

        if (bagIsClosed) {

            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
        }
            
    }

    void OnMouseUp () {

        if (bagOverCustomer) {

            DeliverItems();
        }
        else {

            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }

    void OnMouseOver () {

        if (Input.GetKeyDown("mouse 1")) {

            if (bagIsEmpty) {

                Destroy(gameObject);
            }
            else if (!bagIsEmpty) {

                if (!bagIsClosed) {

                    AttachItemsToBag();
                    CloseBag();
                }
                else if (bagIsClosed) {

                    DetachItemsFromBag();
                    OpenBag();
                }
                
            }
            
        }
    }

    void AttachItemsToBag () {

        foreach (GameObject item in itemsInBag) {

            item.tag = "Packed";
            rgb = item.GetComponent<Rigidbody2D>();
            rgb.bodyType = RigidbodyType2D.Static;
            boxCol = item.GetComponent<BoxCollider2D>();
            boxCol.enabled = false;
            item.transform.parent = this.transform;
        }
    }

    void CloseBag () {

        bagIsClosed = true;
        //col.isTrigger = true;
        handle.SetActive(true);
    }

    void OpenBag () {

        bagIsClosed = false;
        //col.isTrigger = false;
        handle.SetActive(false);
    }

    void DeliverItems () {


    }

    void DetachItemsFromBag () {

        foreach (GameObject item in itemsInBag) {

            rgb = item.GetComponent<Rigidbody2D>();
            rgb.bodyType = RigidbodyType2D.Dynamic;
            item.tag = "Packed";
            boxCol = item.GetComponent<BoxCollider2D>();
            boxCol.enabled = true;
            item.transform.parent = null;
            //item.tag = "Draggable";
        }
    }
}
