using UnityEngine;

public class KillWall : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = this.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ball")
        {
            _audioSource.Play();
            Destroy(collision.transform.gameObject);
            MainScene.Instance.PanelLose.SetActive(true);
        }
    }
}
