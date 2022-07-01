using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int NumberScene;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
