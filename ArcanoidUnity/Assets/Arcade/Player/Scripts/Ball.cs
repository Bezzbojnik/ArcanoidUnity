using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed;

    void Start()
    {
        Respawn();
        //GetComponent<Rigidbody>().AddForce(new Vector3(100, 0, 100));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);

        }
    }

    public void Respawn()
    {
        transform.position = Vector3.zero;
        GetComponent<Rigidbody>().velocity = Random.insideUnitSphere.normalized * Speed;
    }
}
