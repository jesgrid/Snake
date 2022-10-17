using UnityEngine;

public class PlayerHeadRotation : MonoBehaviour
{
    public float RotationSpeed;
    public Transform Head;
    void Update()
    {
        Head.Rotate(0, RotationSpeed * Time.deltaTime, 0);
    }
}
