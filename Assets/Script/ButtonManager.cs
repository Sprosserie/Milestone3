using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    public void ExitGameButton()
    {
        Application.Quit();

    }
    public void NewLevelButton(string newLevel)
    {
        SceneManager.LoadScene(newLevel);
    }
}
