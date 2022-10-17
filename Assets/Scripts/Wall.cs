using TMPro;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int HP;
    public TextMeshProUGUI Text;
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
                Destroy(this.gameObject);
            }
            else
            {
                HP--;
                player.Food--;
            }
        }
    }
}
