using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    private void OnCollisionEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Player") {
            ScreenManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
