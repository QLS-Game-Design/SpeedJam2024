using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DimensionSwitch : MonoBehaviour
{

    public bool isGlitched; 
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] boxes= GameObject.FindGameObjectsWithTag(""); //your tag name here
        foreach (var item in boxes)
        {
            if (item!=this.gameObject) //for others
            {
                item.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
