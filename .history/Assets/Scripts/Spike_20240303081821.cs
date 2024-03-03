using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            // Player collided with the spike, handle the death logic here
            // For example, you can reload the level or play a death animation
            Debug.Log("Player hit the spike!");
        }
    }

}
