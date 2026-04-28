using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HierarchyPanelUI : MonoBehaviour
{
    [Header("Buttons")]
    public Button skeletonButton;
    public Button musclesButton;
    public Button returnButton;

    [Header("Scene Names")]
    public string skeletonSceneName = "Skeleton";
    public string musclesSceneName = "Muscles";

    void Start()
    {
        // Assign button listeners
        skeletonButton.onClick.AddListener(LoadSkeletonScene);
        musclesButton.onClick.AddListener(LoadMusclesScene);
	returnButton.onClick.AddListener(LoadStartScene);
        UpdateButtonStates();
    }

    void UpdateButtonStates()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        // Disable button if already in that scene
        skeletonButton.interactable = currentScene != skeletonSceneName;
        musclesButton.interactable = currentScene != musclesSceneName;
    }

    void LoadSkeletonScene()
    {
        if (SceneManager.GetActiveScene().name == skeletonSceneName)
            return;

        SceneManager.LoadScene(skeletonSceneName);
    }

    void LoadMusclesScene()
    {
        if (SceneManager.GetActiveScene().name == musclesSceneName)
            return;

        SceneManager.LoadScene(musclesSceneName);
    }

    void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}