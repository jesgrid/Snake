using UnityEngine;
using TMPro;

public class BodyPartsCounter : MonoBehaviour
{
    public Player Player;
    public TextMeshProUGUI Text;
    void Update()
    {
        Text.text = "��������: " + Player.BodyParts.Count.ToString();
    }
}
