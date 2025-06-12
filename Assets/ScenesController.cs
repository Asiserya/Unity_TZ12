using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ScenesController : MonoBehaviour
{
    public GameObject pauseButton;
    public Image buttonImage;

    public GameObject pausePanel;

    [SerializeField] private bool paused;

    public void PauseGame()
    {

        if (paused)
        {
            pauseButton.SetActive(true);
            pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            pauseButton.SetActive(false);
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }

        paused = !paused;
    }
}
