using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject DAIHATSU;
    public GameObject SUZUKI;
    public GameObject TOYOTA;
    public GameObject NISSAN;
    public Transform SPAWNER;
    public bool ZZZDAIHATSU;
    public bool ZZZSUZUKI;
    public bool ZZZTOYOTA;
    public bool ZZZNISSAN;
    void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        ZZZDAIHATSU = data.ZZZDAIHATSU;
        ZZZSUZUKI = data.ZZZSUZUKI;
        ZZZTOYOTA = data.ZZZTOYOTA;
        ZZZNISSAN = data.ZZZNISSAN;
    }
    void Update()
    {
        if (ZZZDAIHATSU)
        {
            Instantiate(DAIHATSU, SPAWNER);
            Destroy(this.gameObject);
        }
        if (ZZZSUZUKI)
        {
            Instantiate(SUZUKI, SPAWNER);
            Destroy(this.gameObject);
        }
        if (ZZZTOYOTA)
        {
            Instantiate(TOYOTA, SPAWNER);
            Destroy(this.gameObject);
        }
        if (ZZZNISSAN)
        {
            Instantiate(NISSAN, SPAWNER);
            Destroy(this.gameObject);
        }
    }
}
