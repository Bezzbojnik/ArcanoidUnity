using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void OnClick_StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void OnClick_Exit()
    {
        Application.Quit();
    }
}
