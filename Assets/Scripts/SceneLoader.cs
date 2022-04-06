using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ChangeScene(int NumberScene)
    {
        SceneManager.LoadScene(NumberScene);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
