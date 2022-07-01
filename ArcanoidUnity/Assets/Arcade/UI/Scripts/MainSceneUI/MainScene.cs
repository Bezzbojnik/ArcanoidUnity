using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public static MainScene Instance;
    public GameObject PanelLose;
    public GameObject PanelWin;
    public AudioClip WinAudio;
    public AudioClip LoseAudio;

    private List<GameObject> Enemys = new List<GameObject>();
    private AudioSource _audioSource;

    void Start()
    {
        Instance = this;

        _audioSource = this.GetComponent<AudioSource>();

        var Enemys2 = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in Enemys2)
        {
            Enemys.Add(enemy);
        }
    }

    public void DestroyEnemy(GameObject enemy)
    {
        var locEnemy = MainScene.Instance.Enemys.Find(x => x == enemy);
        Enemys.Remove(locEnemy);
        Destroy(enemy);

        if (Enemys.Count == 0)
        {
            PanelWin.SetActive(true);
            ActivateAudioWin();
        }
    }

    public void Win()
    {
        PanelWin.SetActive(false);
        GameManager.NumberScene++ ;
        SceneManager.LoadScene($"Level {GameManager.NumberScene}");
    }

    public void ActivateAudioWin()
    {
        _audioSource.clip = WinAudio;
        _audioSource.Play();
    }

    public void ActivateAudioLose()
    {
        _audioSource.clip = LoseAudio;
        _audioSource.Play();
    }

    public void Lose()
    {
        PanelLose.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
