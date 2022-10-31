using TMPro;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int FoodHave;
    private System.Random rnd = new();

    public AudioClip FoodClip;

    public TextMeshProUGUI Text;
    private void Update()
    {
        Text.text = FoodHave.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            AudioSource.PlayClipAtPoint(FoodClip, transform.position);
            player.Food += FoodHave;
            Destroy(this.gameObject);
        }
    }
}
