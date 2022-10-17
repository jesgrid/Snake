using UnityEngine;

public class Controls : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float SpeedForward;

    public float AngleMultiplier;
    private float Angle;
    void Update()
    {
        Rigidbody.velocity = new Vector3 (Angle * 100, 0, SpeedForward * 100 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            Angle -= 1 * AngleMultiplier;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Angle += 1 * AngleMultiplier;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            Angle = 0;
        }
    }
}
