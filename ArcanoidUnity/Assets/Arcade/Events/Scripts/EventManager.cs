using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void OnWin();
    public static event OnWin StopBall;

    private void Start()
    {
        
    }

    public static void OnWinStopBall()
    {
        StopBall?.Invoke();
    }

}
