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
        GameObject[] boxes= GameObject.FindGameObjectsWithTag("NormalDimension"); //your tag name here
        foreach (var item in NormalDimension)
        {
            if (item!=this.gameObject)
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
