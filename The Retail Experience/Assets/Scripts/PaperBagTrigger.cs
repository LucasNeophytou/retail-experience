using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperBagTrigger : MonoBehaviour
{
    
    void OnMouseDown () {

        BagSpawner.instance.paperBagClicked = true;
        Debug.Log("Paper bag was clicked");
    }
}
