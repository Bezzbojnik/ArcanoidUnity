using UnityEngine;

public class Ball : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(100, 0, 100));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);

        }
    }
}
