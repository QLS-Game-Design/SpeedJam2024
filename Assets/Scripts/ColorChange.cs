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
        myCollider = GetComponent<Collider2D>();

        if (myCollider != null)
        {
            if (myCollider.enabled)
            {
                Debug.Log("Collider is enabled");
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

                 if (spriteRenderer != null)
                {
                    spriteRenderer.color = Color.green;
                }
            }
            else
            {
                Debug.Log("Collider is disabled");
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

                if (spriteRenderer != null)
                {   
                   spriteRenderer.color = Color.white;
                }
            }
        }
    }
}
