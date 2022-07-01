using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelWin : MonoBehaviour
{
    public void OnClick_NextLvl()
    {
        MainScene.Instance.Win();
    }

    public void OnClick_Exit()
    {
        MainScene.Instance.Exit();
    }

}
