 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;

 public class SceneController : MonoBehaviour
 {
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadMenuScene() {
        SceneManager.LoadScene("StartingMenu");
    }

    // public void NextScene() {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }

    // public void ReloadScene() {
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }

    public void StartLevel() {
        SceneManager.LoadScene("Level1");
    }
}