using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagLocationTrigger : MonoBehaviour
{
    
    void OnTriggerEnter2D (Collider2D other) {

        if (other.tag == "Bag") {

            if (this.name == "BagLocation1") {

                BagSpawner.instance.location1Filled = true;
            }
            else if (this.name == "BagLocation2") {

                BagSpawner.instance.location2Filled = true;
            }
            else if (this.name == "BagLocation3") {

                BagSpawner.instance.location3Filled = true;
            }
            
        }
    }

    void OnTriggerExit2D (Collider2D other) {

        if (other.tag == "Bag") {

            if (this.name == "BagLocation1") {

                BagSpawner.instance.location1Filled = false;
            }
            else if (this.name == "BagLocation2") {

                BagSpawner.instance.location2Filled = false;
            }
            else if (this.name == "BagLocation3") {

                BagSpawner.instance.location3Filled = false;
            }
        }
    }
}
