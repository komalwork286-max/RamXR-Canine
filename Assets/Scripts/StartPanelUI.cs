using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPanelUI : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitButtonPressed()
    {
        Debug.Log("Quit button pressed");

        Application.Quit();
    }
}