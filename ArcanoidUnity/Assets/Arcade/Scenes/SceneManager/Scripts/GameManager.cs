using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<GameObject> Enemys = new List<GameObject>();

    void Start()
    {
        Instance = this;

        var Enemys2 = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in Enemys2)
        {
            Enemys.Add(enemy);
        }
    }

    void Update()
    {
        
    }
}
