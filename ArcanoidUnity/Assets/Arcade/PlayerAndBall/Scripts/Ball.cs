using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed;
    public AudioClip[] AudioClips;

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
        EventManager.OnStopBall += StopBall;
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
            MainScene.Instance.DestroyEnemy(collision.gameObject);
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

    public void StopBall()
    {
        _velocity = new Vector3(0, 0, 0);
        _rb.velocity = _velocity;
        EventManager.OnStopBall -= StopBall;
    }
}
