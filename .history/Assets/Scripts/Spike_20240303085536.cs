using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Start is called before the first frame update
     private Collider2D myCollider; // Reference to the Collider2D component

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
        } else {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer != null)
        {
            // Set the new color to the SpriteRenderer's color property
            spriteRenderer.color = Color.bl;
        }
        }
    }
}
