using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void StartGame(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void PlayGame(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void InstructionsGame(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

}
