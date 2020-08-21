using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    
    public static Variables instance;
    public List<string> groceryItemName;
    public List<float> groceryItemPrice;

    void Awake () {

        instance = this;
    }


}
