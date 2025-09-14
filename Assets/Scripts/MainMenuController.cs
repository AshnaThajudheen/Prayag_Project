using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject secondMenuPanel;

    public void StartGame()
    {
        Debug.Log("Start button clicked!"); // check in Console
        mainMenuPanel.SetActive(false);
        secondMenuPanel.SetActive(true);
    }
}
