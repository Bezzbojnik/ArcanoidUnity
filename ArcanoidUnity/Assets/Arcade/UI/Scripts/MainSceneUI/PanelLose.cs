using UnityEngine;

public class PanelLose : MonoBehaviour
{
    public void OnClick_ResetLevel()
    {
        MainScene.Instance.Lose();
    }

    public void OnClick_ExitGame()
    {
        MainScene.Instance.Exit();
    }
}
