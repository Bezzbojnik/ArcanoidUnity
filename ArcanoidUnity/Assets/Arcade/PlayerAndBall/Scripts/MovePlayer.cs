using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        if(transform.position.x > 3.5f)
        {
            transform.position = new Vector3(3.5f, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -3.5f)
        {
            transform.position = new Vector3(-3.5f, transform.position.y, transform.position.z);
        }

        transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * Speed, transform.position.y, transform.position.z);

    }
}
