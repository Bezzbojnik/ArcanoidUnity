using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ParticleSystem Explosions;
    public bool IsMove;

    private AudioSource _audioSource;
    private float directionRight;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        directionRight = 1f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsMove)
        {
            MoveEnemy();
        }
    }

    private void MoveEnemy()
    {
        if (transform.position.x > 3.5f && directionRight > 0)
        {
            transform.position = new Vector3(3.4f, transform.position.y, transform.position.z);
            directionRight = -directionRight;
        }
        if (transform.position.x < -3.5f && directionRight < 0)
        {
            transform.position = new Vector3(-3.4f, transform.position.y, transform.position.z);
            directionRight = -directionRight;
        }

        transform.position = new Vector3(transform.position.x + directionRight, transform.position.y, transform.position.z);
    }

    public void OnDestroyEnemy()
    {
        Explosions.Play();
        _audioSource.Play();
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        Destroy(gameObject, 0.3f);
    }
}
