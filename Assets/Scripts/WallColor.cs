using UnityEngine;

public class WallColor : MonoBehaviour
{
    public GameObject _spawner;
    public Wall Wall;

    private float HP;
    private float MaxHP;

    private void Start()
    {
        _spawner = GameObject.Find("Spawner");
        MaxHP = _spawner.GetComponent<Spawner>().WallMaxHP;
        HP = Wall.HP;
        GetComponent<Renderer>().material.SetFloat("_Food", 1 - (HP /MaxHP));
    }
}
