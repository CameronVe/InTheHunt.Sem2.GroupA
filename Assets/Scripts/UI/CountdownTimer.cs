using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float currentTime;
    public bool countDown;
    public string nameOfEndGameScene = "EndGame";

    void Start()
    {
        
    }

    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        if (currentTime <= 0f)
        {
            currentTime = 0f;
        }
        timerText.text = currentTime.ToString("0.00");

        if (currentTime <= 0f)
        {
            SceneManager.LoadScene("EndGame", LoadSceneMode.Single);
        }
    
    }
    

    }
