using UnityEngine;


public class LevelProgressBar : MonoBehaviour
{
    public Transform Finish;
    public Player Player;
    public UnityEngine.UI.Slider slider;
    private float StartPosition;
    private float CurrentPosition;
    private float LastPosition;

    private void Start()
    {
        StartPosition = Player.transform.position.z;
        LastPosition = Finish.position.z;
    }
    private void Update()
    {
        CurrentPosition = Player.transform.position.z;
        if (slider.value < Mathf.InverseLerp(StartPosition, LastPosition, CurrentPosition))
        {
            slider.value = Mathf.InverseLerp(StartPosition, LastPosition, CurrentPosition);
        }
    }
}
