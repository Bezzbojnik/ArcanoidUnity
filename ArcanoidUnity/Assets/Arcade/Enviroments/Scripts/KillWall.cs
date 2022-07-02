using UnityEngine;

public class KillWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ball")
        {
            EventManager.OnStopBall?.Invoke();
            MainScene.Instance.PanelLose.SetActive(true);
            MainScene.Instance.ActivateAudioLose();
        }
    }
}
