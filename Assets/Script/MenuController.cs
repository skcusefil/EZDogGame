using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayButonClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitButtonClick()
    {
        Application.Quit();
    }
}
