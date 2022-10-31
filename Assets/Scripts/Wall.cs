using TMPro;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int HP;
    public TextMeshProUGUI Text;

    public AudioClip Drill;
       void Update()
    {
        Text.text = HP.ToString();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            if (HP <= 0)
            {
                    Destroy(gameObject);
            }
            else
            {
                HP--;
                player.Food--;
                AudioSource.PlayClipAtPoint(Drill, transform.position);
            }
        }
    }
}
