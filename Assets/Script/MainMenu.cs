using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Exit(){
        
        Application.Quit();
        Debug.Log("Application was Quit");
    }
    public void AboutVirus(){
        SceneManager.LoadScene("AboutVirus");
    }

    public void VideoExplaination(){
        SceneManager.LoadScene("Video");
    }

    public void ARVirus(){
        SceneManager.LoadScene("ARVirus");
    }


}