using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DirectingBack : MonoBehaviour
{
    public void BackToGame(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
