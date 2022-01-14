using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GUIManager : MonoBehaviour
{
    public static int score = 0;
    public static int lives_count = 0;
    public void OnPlayEasy()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scenes/SampleScene");
    }

    public void OnPlayMedium()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scenes/SampleSceneMedium");
    }

    public void OnPlayHard()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scenes/SampleSceneHard");
    }

    public void OnPlayHuman()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scenes/SampleSceneHuman");
    }

    public void OnPlay()
    {
        SceneManager.LoadScene("Scenes/MenuLevel");
    }

    public void OnRestart()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        print("The Button is working");
        Time.timeScale = 1;
        lives_count = 5;
        score=0;
    }

    public void OnRestartMedium()
    {
        SceneManager.LoadScene("Scenes/SampleSceneMedium");
        print("The Button is working");
        Time.timeScale = 1;
        lives_count = 5;
        score=0;
    }

    public void OnRestartHard()
    {
        SceneManager.LoadScene("Scenes/SampleSceneHard");
        print("The Button is working");
        Time.timeScale = 1;
        lives_count = 5;
        score=0;
    }

    public void OnRestartNotHuman()
    {
        SceneManager.LoadScene("Scenes/SampleSceneHuman");
        print("The Button is working");
        Time.timeScale = 1;
        lives_count = 5;
        score=0;
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void OnBackMenu()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void OnHelp()
    {
        SceneManager.LoadScene("Scenes/help");
    }

    public void OnCredit()
    {
        SceneManager.LoadScene("Scenes/credit");
    }
}
