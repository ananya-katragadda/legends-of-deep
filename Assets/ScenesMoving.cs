using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesMoving : MonoBehaviour
{
    public void SceneT(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
