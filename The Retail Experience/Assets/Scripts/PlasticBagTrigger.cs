using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticBagTrigger : MonoBehaviour
{
    
    void OnMouseDown () {

        BagSpawner.instance.plasticBagClicked = true;
        Debug.Log("Plastic bag was clicked");
    }
}
