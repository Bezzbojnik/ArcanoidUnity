using UnityEngine;

public class MainScene : MonoBehaviour
{
    public static MainScene Instance;
    public GameObject PanelLose;
    public GameObject PanelWin;

    void Start()
    {
        Instance = this;
    }
}
