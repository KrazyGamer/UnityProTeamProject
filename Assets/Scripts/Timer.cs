using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeLeft;
    public bool isTimer;


    MainMenuManager menuMan;
    UIManager UIman;

    
    void Start()
    {
        timeLeft = 60f;

        UIman = GameObject.FindGameObjectWithTag("GameUI").GetComponent<UIManager>();
        StartTimer();

    }

    void Update()
    {
        if (isTimer)
        {
            timeLeft -= Time.deltaTime;

            if (timeLeft <= 0f)
            {
                timeLeft = 0f;
                UIman.UpdateTimer(timeLeft);
                StopTimer();

            }

            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        if (timeLeft > 0)
        {
            UIman.UpdateTimer(timeLeft);
        }
    }

    public void StartTimer()
    {
        isTimer = true;
    }

    public void StopTimer()
    {
        isTimer = false;
        UIman.endGame();
    }
}
