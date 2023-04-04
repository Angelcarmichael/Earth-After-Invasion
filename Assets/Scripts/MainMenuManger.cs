using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MainMenuManger : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void Settings()
    {
        SceneManager.LoadScene(2);
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
    }

    public void SelectCharacter()
    {
        SceneManager.LoadScene(3);
    }

    public void SaveSlot()
    {
        SceneManager.LoadScene(4);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ReturnToSave()
    {
        SceneManager.LoadScene(1);
    }
}
