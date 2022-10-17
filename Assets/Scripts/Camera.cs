using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject CameraViev;
    public GameObject Player;
    void Update()
    {
        CameraViev.transform.LookAt(Player.transform.position);
        this.transform.position = new Vector3(0, Player.transform.position.y, Player.transform.position.z);
    }
}
