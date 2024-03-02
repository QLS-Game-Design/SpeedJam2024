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
        
        if (Input.GetKeyDown("c")) {
            if (isGlitched == false) {
                GameObject[] norm = GameObject.FindGameObjectsWithTag("NormalDimension"); 
                foreach (var item in norm)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider>().enabled = false;
                    }
                }
            } else {
                GameObject[] glitched = GameObject.FindGameObjectsWithTag("GlitchedDimension"); 
                foreach (var item in glitched)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider2D>().enabled = false;
                    } else
                        item.GetComponent<BoxCollider2D>().enabled = true;
                    }
                }
            }
        } 
    }
}
