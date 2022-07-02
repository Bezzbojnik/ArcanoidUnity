using UnityEngine;

public class PanelWinAllGame : MonoBehaviour
{
    public void OnClick_BackToMenu()
    {
        MainScene.Instance.WinAllGame();
    }

    public void OnClick_ExitGame()
    {
        MainScene.Instance.Exit();
    }
}
