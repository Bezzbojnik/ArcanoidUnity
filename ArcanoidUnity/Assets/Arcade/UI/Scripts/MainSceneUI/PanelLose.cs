using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelLose : MonoBehaviour
{
    public void OnClick_ResetLevel()
    {
        MainScene.Instance.PanelLose.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnClick_ExitGame()
    {
        Application.Quit();
    }
}
