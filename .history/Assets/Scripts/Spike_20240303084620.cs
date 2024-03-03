using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collision.collider.enabled)
        {
            Debug.Log("Collision is enabled");
        }
        else
        {
            Debug.Log("Collision is disabled");
        }
    }
}
