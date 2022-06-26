using UnityEngine;

public class MainScene : MonoBehaviour
{
    public static MainScene Instance;
    public GameObject PanelLose;

    void Start()
    {
        Instance = this;
    }
}
