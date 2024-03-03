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
        // Get the Collider2D component attached to this GameObject
        myCollider = GetComponent<Collider2D>();

        // Check if the Collider2D component is found
        if (myCollider != null)
        {
            // Check if the collider is enabled
            if (myCollider.enabled)
            {
                Debug.Log("Collider is enabled");
            }
            else
            {
                Debug.Log("Collider is disabled");
            }
        }
    }
}
