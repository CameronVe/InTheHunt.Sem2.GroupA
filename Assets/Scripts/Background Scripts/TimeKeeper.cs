using UnityEngine;
using TMPro; //Make sure you include this namespace
using System; //Make sure you include this namespace
using UnityEngine.SceneManagement;


/// <summary>
/// This script:
///         stores the timer value,
///         modifies the timer value, 
///         displays the timer value, and
///         changes the scene when timer reaches 0.
/// </summary>

public class TimeKeeper : MonoBehaviour

{
    public string SceneName;
    [HideInInspector] public float timer = 0.0f;
    public float totalAllowedTime = 60f;
    public bool isCountingDown;
    public bool isFrozen = false;

    public int clockSpeed = 1;

    public TextMeshProUGUI textMeshProItem;

    [HideInInspector] public TimeSpan timeSpan;



    void Update()
    {
        //The clock speed is used to artificially influence the timer
        //Using a value of 1 is close to a normal clock
        //Note: Over long periods of time this is not an accurate timer
        //      but it is unlikely the user will last that long to notice

        timer += Time.deltaTime * clockSpeed;

        UpdateScoreText();
        GameOverCheck();
    }



    void UpdateScoreText()
    {
        if (isFrozen == false)
        {
            //The TimeSpan class takes care of the heavy lifting
            //There are manual ways to do this but they are unnecessary
            //for our use case - and too much work!

            timeSpan = TimeSpan.FromSeconds(timer);
            if (isCountingDown)
            {
                timeSpan = TimeSpan.FromSeconds(totalAllowedTime - timer);
            }
            //dd\\.hh\\:mm\\:ss\\.fffffff
        }

        //textMeshProItem.text = ">>" + timeSpan.TotalSeconds.ToString("00") + "<<";
        textMeshProItem.text = timeSpan.TotalSeconds.ToString("00");
    }



    //Scene changes as timer reaches 0.
    

    void GameOverCheck()
    {
        if (timer >= totalAllowedTime)

        {

            //Hard coded values = bad!
            //SceneManager.LoadScene("End");

            //Values provided from variables = good!

            SceneManager.LoadScene(SceneName);

        }
    }

}