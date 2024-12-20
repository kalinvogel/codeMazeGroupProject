using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{


    //this action is referenced by the play button on the main menu scene
    public void PlayGame()
    {
        //load the level selector UI
        SceneManager.LoadSceneAsync(1);
        //1 is a reference to File/Build Settings/Scenes In Build 
        //you can acces this through the unity editor to change it or see what the heirarchy of scenese currently looks like
    }


    //this action is referenced by the quit button on the main menu scenc
    public void QuitGame()
    {
        Application.Quit();
    }
}
