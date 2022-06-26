using UnityEngine;

public class KillWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ball")
        {
            Destroy(collision.transform.gameObject);
            MainScene.Instance.PanelLose.SetActive(true);
        }
    }
}
