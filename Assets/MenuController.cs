using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    public GameObject mainMenuController;
    public GameObject selectLevelPanel;
    public GameObject authorPanel;

    public Button LevelOne;
    public Button LevelTwo;
    public Button LevelThree;

    void Start()
    {
        mainMenuController.SetActive(true);
        selectLevelPanel.SetActive(false);
        authorPanel.SetActive(false);
    }

    public void ShowMainMenu()
    {
        mainMenuController.SetActive(true);
        selectLevelPanel.SetActive(false);
        authorPanel.SetActive(false);
    }

    public void ShowLevelSelectPanel()
    {
        mainMenuController.SetActive(false);
        selectLevelPanel.SetActive(true);
        authorPanel.SetActive(false);
    }

    public void ShowAuthorPanel()
    {
        mainMenuController.SetActive(false);
        selectLevelPanel.SetActive(false);
        authorPanel.SetActive(true);
    }

    public void LevelSelect(int sceneindex)
    {
        SceneManager.LoadScene(sceneindex);
    }
}
