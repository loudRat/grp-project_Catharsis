using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timertext;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
        if(timeRemaining == 0)
        {
            SceneManager.LoadScene("GameWin");
        }
        DisplayTime(timeRemaining);
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay = Timerminute(timeToDisplay);
    }

    private float Timerminute(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timertext.text = string.Format("Time:{0:00}:{1:00}", minutes, seconds);
        return timeToDisplay;
    }
}
