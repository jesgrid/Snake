using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    public Player Player;
    public Rigidbody Rigidbody;
    private Vector3 TargetVector;
    public int PartIndex;
    public PlayerBody PreviousPart;
    public GameObject BodyBack;

    //Для хвоста
    public GameObject BodyView;
    public GameObject TailView;
    void Update()
    {
        if(PartIndex == Player.BodyParts.Count)
        {
            BodyView.SetActive(false);
            TailView.SetActive(true);
        }
        else
        {
            BodyView.SetActive(true);
            TailView.SetActive(false);
        }

        if(PartIndex == 1)
        {
            this.transform.LookAt(Player.transform.position);
            TargetVector = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - 2);
            Rigidbody.transform.position = Vector3.Lerp(Rigidbody.transform.position, TargetVector, 10 * Time.deltaTime);
        }
        else
        {
            PreviousPart = Player.BodyParts.Find(x => x.PartIndex == PartIndex - 1);
            this.transform.LookAt(PreviousPart.BodyBack.transform);
            TargetVector = new Vector3(PreviousPart.BodyBack.transform.position.x, PreviousPart.BodyBack.transform.position.y, PreviousPart.BodyBack.transform.position.z - 1f);
            Rigidbody.transform.position = Vector3.Lerp(Rigidbody.transform.position, TargetVector, 19 * Time.deltaTime);
        }
    }
}
