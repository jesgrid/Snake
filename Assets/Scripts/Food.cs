using TMPro;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int FoodHave;
    private System.Random rnd = new();

    public TextMeshProUGUI Text;
    private void Update()
    {
        Text.text = FoodHave.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.Food += FoodHave;
            Destroy(this.gameObject);
        }
    }
}
