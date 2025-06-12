using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BackToMenuController : MonoBehaviour
{
    public Button menuBackButton;

    public void LoadMenuScene(int sceneindex)
    {
        SceneManager.LoadScene(sceneindex);
    }
}
