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
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if 
        GameObject[] norm = GameObject.FindGameObjectsWithTag("NormalDimension"); 
        foreach (var item in norm)
        {
            if (item!=this.gameObject)
            {
                item.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
}
