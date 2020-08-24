using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagSpawner : MonoBehaviour
{
    
    public static BagSpawner instance;

    public bool largeBagClicked;
    public bool paperBagClicked;
    public bool plasticBagClicked;
    public bool location1Filled;
    public bool location2Filled;
    public bool location3Filled;
    public GameObject largeBag;
    public GameObject paperBag;
    public GameObject plasticBag;
    public GameObject bagLocation1;
    public GameObject bagLocation2;
    public GameObject bagLocation3;
    public Vector3 bagPos1;
    public Vector3 bagPos2;
    public Vector3 bagPos3;

    void Awake () {

        instance = this;
        bagPos1 = bagLocation1.transform.position;
        bagPos2 = bagLocation2.transform.position;
        bagPos3 = bagLocation3.transform.position;
    }

    void Update () {

        if (largeBagClicked) {

            PlaceBag (largeBag);
            largeBagClicked = false;
        }
        else if (paperBagClicked) {

            PlaceBag (paperBag);
            paperBagClicked = false;
        }
        else if (plasticBagClicked) {

            PlaceBag (plasticBag);
            plasticBagClicked = false;
        }
    }

    void PlaceBag (GameObject bagType) {

        if (location1Filled == false) {

            GameObject obj = Instantiate(bagType, bagPos1, Quaternion.identity) as GameObject;
        }
        else if (location2Filled == false) {

            GameObject obj = Instantiate(bagType, bagPos2, Quaternion.identity) as GameObject;
        }
        else if (location3Filled == false) {

            GameObject obj = Instantiate(bagType, bagPos3, Quaternion.identity) as GameObject;
        }
        else {

            return;
        }
    }

    
}
