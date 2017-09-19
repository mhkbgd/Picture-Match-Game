using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public void quit() {
        Application.Quit();

    }

  
    

    public void level1(string result)
    {
        switch (result)
        {
            default:
            case "correct":

                SceneManager.LoadScene("level2");
                break;

            case "wrong":
                SceneManager.LoadScene("level2");
                break;

            
        }

    }


    public void level2(string result)
    {
        switch (result)
        {
            default:
            case "correct":

                SceneManager.LoadScene("level3");
                break;

            case "wrong":
                SceneManager.LoadScene("level3");
                break;


        }

    }

   
}
