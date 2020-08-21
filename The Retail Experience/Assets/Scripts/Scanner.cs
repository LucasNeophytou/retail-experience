using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    
    public List<string> scannedItemName = new List<string>();
    public List<float> scannedItemPrice = new List<float>();
    
    void OnTriggerEnter2D (Collider2D other) {

        if (other.tag == "Draggable") {

            if (other.name.Contains(Variables.instance.groceryItemName[0])) {

                ScanItem(Variables.instance.groceryItemName[0], Variables.instance.groceryItemPrice[0]);
            }
            else if (other.name.Contains(Variables.instance.groceryItemName[1])) {

                ScanItem(Variables.instance.groceryItemName[1], Variables.instance.groceryItemPrice[1]);
            }
            else if (other.name.Contains(Variables.instance.groceryItemName[2])) {

                ScanItem(Variables.instance.groceryItemName[2], Variables.instance.groceryItemPrice[2]);
            }
        }
    }

    void ScanItem (string itemName, float itemPrice) {

        scannedItemName.Add(itemName);
        scannedItemPrice.Add(itemPrice);
    }
}
