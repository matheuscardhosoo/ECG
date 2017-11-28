using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScene(string changeScene)
    {
        SceneManager.LoadScene(changeScene);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
