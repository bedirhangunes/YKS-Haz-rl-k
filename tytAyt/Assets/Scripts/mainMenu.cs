using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
   public void literatureQuestion()
    {
        SceneManager.LoadScene("level2");
    }
    public void turkishQuestion()
    {
        SceneManager.LoadScene("level1");
    }
   public void quitToProgram()
    {
        Application.Quit();
    }
    public void retMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
