using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DimensionSwitch : MonoBehaviour
{

    private bool isGlitched; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("c")) {
            //norm dimension
            if (isGlitched == false) {
                isGlitched = true;
                GameObject[] norm = GameObject.FindGameObjectsWithTag("NormalDimension"); 
                foreach (var item in norm)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider2D>().enabled = false;
                    }
                }
                GameObject[] glitched = GameObject.FindGameObjectsWithTag("GlitchedDimension"); 
                foreach (var item in glitched)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider2D>().enabled = true;
                    }
                }
                GameObject[] normTrap = GameObject.FindGameObjectsWithTag("NormalDimensionTrap"); 
                foreach (var item in normTrap)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider2D>().enabled = false;
                    }
                }
                GameObject[] glitchedTrap = GameObject.FindGameObjectsWithTag("GlitchedDimensionTrap"); 
                foreach (var item in glitchedTrap)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider2D>().enabled = true;
                    }
                }
            //glitched dimension
            } else {
                isGlitched = false;
                GameObject[] glitched = GameObject.FindGameObjectsWithTag("GlitchedDimension"); 
                foreach (var item in glitched)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider2D>().enabled = false;
                    }
                }
                GameObject[] norm = GameObject.FindGameObjectsWithTag("NormalDimension"); 
                foreach (var item in norm)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider2D>().enabled = true;
                    }
                }
                GameObject[] glitchedTrap = GameObject.FindGameObjectsWithTag("GlitchedDimensionTrap"); 
                foreach (var item in glitchedTrap)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider2D>().enabled = false;
                    }
                }
                GameObject[] normTrap = GameObject.FindGameObjectsWithTag("NormalDimensionTrap"); 
                foreach (var item in normTrap)
                {
                    if (item!=this.gameObject)
                    {
                        item.GetComponent<BoxCollider2D>().enabled = true;
                        item.color = 
                    }
                }
            }
        } 
    }
}
