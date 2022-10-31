using UnityEngine;

public class WinLose : MonoBehaviour
{
    public Player Player;
    public Controls Controls;
    public Canvas LoseScreen;
    public Canvas WinScreen;
    public Finish Finish;
    private void FixedUpdate()
    {
        if (Player.BodyParts.Count == 0)
        {
            Controls.enabled = false;
            LoseScreen.gameObject.SetActive(true);
        }
        if (Finish.Finished == true)
        {
            Controls.enabled = false;
            WinScreen.gameObject.SetActive(true);
        }
    }
}
