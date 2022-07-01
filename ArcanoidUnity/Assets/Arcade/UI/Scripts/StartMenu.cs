using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void OnClick_StartGame()
    {
        GameManager.NumberScene = 1;
        SceneManager.LoadScene($"Level {GameManager.NumberScene}");
    }

    public void OnClick_Exit()
    {
        Application.Quit();
    }
}
