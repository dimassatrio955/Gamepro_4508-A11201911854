using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnPlay()
    {
        SceneManager.LoadScene("Scenes/SampleScene"); 
    }

    public void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
