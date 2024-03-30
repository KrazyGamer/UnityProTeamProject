using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //reference UI elements that change
    [SerializeField] Text timerText;
    [SerializeField] Text scoreText;
    [SerializeField] Text resultsText;

    public GameObject Results;

    void Start()
    {
        Results.SetActive(false);
    }

    public void UpdateTimer(float amount)
    {
        timerText.text = amount.ToString();
    }

    public void UpdateScore(float amount)
    {
        scoreText.text = amount.ToString();
    }

    public void UpdateResults(float amount)
    {
        resultsText.text = amount.ToString();
    }

    public void endGame()
    {
        Results.SetActive(true);
    }

}
