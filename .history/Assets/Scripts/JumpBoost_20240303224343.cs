using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "NormalDimension" 
            || collision.gameObject.tag == "GlitchedDimension"
            || collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
        if (collision.gameObject.CompareTag("GlitchedDimensionTrap") || collision.gameObject.CompareTag("NormalDimensionTrap"))
        {
            Debug.Log("Player hit the spike!");
            die();
            //death
        }
        
    } 
}
