using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeBagTrigger : MonoBehaviour
{
    
    void OnMouseDown () {

        BagSpawner.instance.largeBagClicked = true;
        Debug.Log("Large bag was clicked");
    }
}
