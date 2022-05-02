using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float Speed;

    private float _accuracity = 0.1f;

    void Update()
    {
        if(transform.position.x > 3.5f + _accuracity)
        {
            transform.position = new Vector3(3.5f, transform.position.y, transform.position.z);
        }
        else if(transform.position.x < -3.5f - _accuracity)
        {
            transform.position = new Vector3(-3.5f, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * Speed, transform.position.y, transform.position.z);
        }
    }
}
