using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelWin : MonoBehaviour
{
    
    public void OnClick_NextLvl()
    {
        MainScene.Instance.PanelWin.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnClick_Exit()
    {
        Application.Quit();
    }

}
