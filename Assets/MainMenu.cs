using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public  void StartGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void  QuitGame()
    {
        Application.Quit();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("level1");
    }

    public void HowToPlayBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
