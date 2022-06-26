using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void OnClick_StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnClick_Exit()
    {
        Application.Quit();
    }
}
