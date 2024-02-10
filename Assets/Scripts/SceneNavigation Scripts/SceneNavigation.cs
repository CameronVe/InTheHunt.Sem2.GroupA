using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 *  SceneNavigation Script:
 *  This script allows for swapping between scenes.
 * 
 *   Instructions:
 * - create a 'ScriptHolder' empty game 
 *   object to put this script into.
 * - Add an On Click funtion to a buttonv
 * - Then drag ScriptHolder o
 * - 
 * 
 */

public class SceneNavigation : MonoBehaviour

{
    public void SceneChange(string sceneToChangeTo)
    {
        SceneManager.LoadSceneAsync(sceneToChangeTo, LoadSceneMode.Single);
        Debug.Log(sceneToChangeTo.ToString());
    }

    //Quits Game
    public void QuitGame()
    {
        Application.Quit();
    }

}