using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool IsMove;

    private float directionRight;

    // Start is called before the first frame update
    void Start()
    {
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
}
