using UnityEngine;
using TMPro;

public class BodyPartsCounter : MonoBehaviour
{
    public Player Player;
    public TextMeshProUGUI Text;
    void Update()
    {
        Text.text = "Сарделек: " + Player.BodyParts.Count.ToString();
    }
}
