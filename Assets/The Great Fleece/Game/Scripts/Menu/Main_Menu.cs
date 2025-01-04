using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Loading_Scene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
