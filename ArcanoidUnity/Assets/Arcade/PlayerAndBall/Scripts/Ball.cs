using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed;

    private Rigidbody _rb;
    private Vector3 _velocity;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();

        _velocity = new Vector3(1 * Speed, 1 * Speed, 1 * Speed);
        Debug.Log(_velocity);
        _rb.AddForce(_velocity, ForceMode.VelocityChange);

        //Respawn();
    }

    public void Respawn()
    {
        transform.position = Vector3.zero;
        GetComponent<Rigidbody>().velocity = Random.insideUnitSphere.normalized;
    }

    void OnCollisionEnter(Collision collision)
    {
        ReflectProjectile(_rb, collision.contacts[0].normal);
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject.gameObject);
        }
    }

    private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
    {
        _velocity = Vector3.Reflect(_velocity, reflectVector);
        _rb.velocity = _velocity;
    }
}
