using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public bool Finished;
    private void Awake()
    {
        Finished = false;
    }
    private void OnTriggerStay(Collider other)
    {
        Finished = true;
    }
}
