using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed;
    public AudioClip[] AudioClips;
    public AudioClip WinAudio;

    private Rigidbody _rb;
    private Vector3 _velocity;
    private AudioSource _audioSource;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();

        _velocity = new Vector3(1 * Speed, 1 * Speed, 1 * Speed);
        _rb.AddForce(_velocity, ForceMode.VelocityChange);

        _audioSource = this.GetComponent<AudioSource>();
        Respawn();
    }

    public void Respawn()
    {
        transform.position = Vector3.zero;
        GetComponent<Rigidbody>().velocity = Random.insideUnitSphere.normalized;
    }

    void OnCollisionEnter(Collision collision)
    {
        RandomAudioPlay();
        ReflectProjectile(_rb, collision.contacts[0].normal);
        if (collision.gameObject.tag == "Enemy")
        {
            var enemy = GameManager.Instance.Enemys.Find(x => x == collision.gameObject);
            GameManager.Instance.Enemys.Remove(enemy);
            Destroy(collision.gameObject.gameObject);

            if(GameManager.Instance.Enemys.Count == 0)
            {
                MainScene.Instance.PanelWin.SetActive(true);
                _velocity = new Vector3(0, 0, 0);
                _rb.velocity = _velocity;
                _audioSource.clip = WinAudio;
                _audioSource.Play();
            }
        }
    }

    private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
    {
        _velocity = Vector3.Reflect(_velocity, reflectVector);
        _rb.velocity = _velocity;
    }

    private void RandomAudioPlay()
    {
        _audioSource.clip = AudioClips[Random.Range(0, AudioClips.Length)];
        _audioSource.Play();
    }
}
