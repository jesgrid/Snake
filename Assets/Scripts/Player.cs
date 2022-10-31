using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Food;
    public PlayerBody BodyPart;
    public List<PlayerBody> BodyParts;

    private void Awake()
    {
        BodyParts.Add(Instantiate(BodyPart));
        BodyParts.Last().PartIndex = BodyParts.Count;
        BodyParts.Last().Player = this;
    }
    private void Update()
    {
        if (Food > 0)
        {
            Food--;
            BodyParts.Add(Instantiate(BodyPart));
            BodyParts.Last().PartIndex = BodyParts.Count;
            BodyParts.Last().Player = this;
        }
        else if (Food < 0 & BodyParts.Count > 0)
        {
            Food++;
            Destroy(BodyParts.Last().gameObject);
            BodyParts.RemoveAt(BodyParts.Count - 1);
        }
        
    }
}
