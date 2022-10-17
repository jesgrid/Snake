using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Player Player;
    public Wall WallPrefab;
    public Food FoodPrefab;
    public Finish Finish;
    public GameObject Trace;
    private Wall WallBuilder;
    private Food FoodBuilder;

    //линия раз в 30 метров!
    public int WallLines;
    private int WallOnLine;
    public int WallMaxHP;
    public int FoodMax;


    private float[] WallXPositions;
    private System.Random rnd = new();

    private void Start()
    {
        Trace.transform.localScale = new Vector3(2, 1, WallLines * 4);
        Finish.transform.position = new Vector3(0, 0, 30 * (WallLines + 1));

        if(0 <= PlayerPrefs.GetInt("savedlevel", 0))
        {
            WallPosinionsGennerate();
            FoodPosinionsGennerate();
            WallPosinionsSpawn();
            FoodPosinionsSpawn();
        }
        else
        {
            WallPosinionsSpawn();
            FoodPosinionsSpawn();
            ResetPlayerPosinion();
        }
    }

    private void WallPosinionsGennerate()
    {
        for (int k = 1; k <= WallLines; k++)
        {
            WallXPositions = new float[5] { 8, 4, 0, -4, -8 };
            for (int i = 1; i <= 5; i++)
            {
                WallOnLine = rnd.Next(0, 5);
                PlayerPrefs.SetFloat(k + "." + i + "." + "x", WallXPositions[WallOnLine]);
                PlayerPrefs.SetFloat(k + "." + i + "." + "z", k * 30);
                PlayerPrefs.SetInt(k + "." + i + "." + "HP", rnd.Next(1, WallMaxHP + 1));
                WallXPositions[WallOnLine] = -200;
            }
        }
    }
    private void FoodPosinionsGennerate()
    {
        for (int k = 1; k <= WallLines; k++)
        {
            WallXPositions = new float[9] { 8, 6, 4, 2, 0, -2, -4, -6, -8 };
            for (int i = 1; i <= 3; i++)
            {
                WallOnLine = rnd.Next(0, 9);
                PlayerPrefs.SetFloat(k + "." + i + "." + "xFood", WallXPositions[WallOnLine]);
                PlayerPrefs.SetFloat(k + "." + i + "." + "zFood", (k * 30) + 15);
                PlayerPrefs.SetInt(k + "." + i + "." + "HPFood", rnd.Next(1, FoodMax + 1));
                WallXPositions[WallOnLine] = -200;
            }
        }
    }
    private void WallPosinionsSpawn()
    {
        for (int k = 1; k <= WallLines; k++)
        {
            WallXPositions = new float[5] { 8, 4, 0, -4, -8 };
            for (int i = 1; i <= 5; i++)
            {
                WallBuilder = WallPrefab;
                WallBuilder.transform.position = new Vector3(PlayerPrefs.GetFloat(k + "." + i + "." + "x") , 0, PlayerPrefs.GetFloat(k + "." + i + "." + "z"));
                WallBuilder.HP = PlayerPrefs.GetInt(k + "." + i + "." + "HP");
                Instantiate(WallBuilder);
            }
        }
    }
    private void FoodPosinionsSpawn()
    {
        for (int k = 1; k <= WallLines; k++)
        {
            WallXPositions = new float[9] { 8, 6, 4, 2, 0, -2, -4, -6, -8 };
            for (int i = 1; i <= 3; i++)
            {
                FoodBuilder = FoodPrefab;
                FoodBuilder.transform.position = new Vector3(PlayerPrefs.GetFloat(k + "." + i + "." + "xFood"), 1, PlayerPrefs.GetFloat(k + "." + i + "." + "zFood"));
                FoodBuilder.FoodHave = PlayerPrefs.GetInt(k + "." + i + "." + "HPFood");
                Instantiate(FoodBuilder);
            }
        }
    }

    private void ResetPlayerPosinion()
    {
        Player.transform.position = new Vector3 (0, 1, 10);
        while (Player.BodyParts.Count > 0)
        {
            Destroy(Player.BodyParts.Last().gameObject);
            Player.BodyParts.RemoveAt(Player.BodyParts.Count - 1);
            Player.Food = 4;
        }
    }
}
