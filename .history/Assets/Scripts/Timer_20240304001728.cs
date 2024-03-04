using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public int seconds;
    public int miliseconds;
    float time;
    public TextMeshProUGUI timer;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) < 2)
        minutes = 0;
        seconds = 0;
        miliseconds = 0;
        time = 0.0f;
        // timer = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        minutes = (int)time/60;
        seconds = (int)time%60;
        miliseconds = (int)(100*(time%1));

        timer.text = minutes.ToString() + ":" + seconds.ToString() + ":" + miliseconds.ToString();
    }
}
