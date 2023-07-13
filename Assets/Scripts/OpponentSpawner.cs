using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentSpawner : MonoBehaviour
{
    public float RNG;
    public Transform SPAWNER;
    public GameObject KAR1;
    public GameObject KAR2;
    public GameObject KAR3;
    public GameObject KAR4;
    void Start()
    {
        RNG = Random.Range(1, 5);
        if (RNG == 1)
        {
            Instantiate(KAR1, SPAWNER);
        }
        if (RNG == 2)
        {
            Instantiate(KAR2, SPAWNER);
        }
        if (RNG == 3)
        {
            Instantiate(KAR3, SPAWNER);
        }
        if (RNG == 4)
        {
            Instantiate(KAR4, SPAWNER);
        }
    }
}
