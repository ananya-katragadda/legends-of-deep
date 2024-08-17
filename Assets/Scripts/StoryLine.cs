using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryLine : MonoBehaviour
{
    // Start is called before the first frame update
    public void SL1(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void SL2(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void SL3(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void SL4(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
