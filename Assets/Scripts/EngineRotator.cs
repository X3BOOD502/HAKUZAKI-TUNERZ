using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineRotator : MonoBehaviour
{
    public float RNG;
    public float RotationSpeed = 45f;
    public float ResetAngle = 45f;
    public GameObject KAR1;
    public GameObject KAR2;
    public GameObject KAR3;
    public GameObject KAR4;
    public GameObject KAR5;
    public GameObject KAR6;
    public GameObject KAR7;
    public GameObject KAR8;
    public GameObject KAR9;
    public GameObject KAR10;
    public GameObject KAR11;
    public GameObject KAR12;
    void Start()
    {
        ResetRotation();
        RNG = Random.Range(1, 13);
        if (RNG == 1)
        {
            Instantiate(KAR1, this.transform);
        }
        if (RNG == 2)
        {
            Instantiate(KAR2, this.transform);
        }
        if (RNG == 3)
        {
            Instantiate(KAR3, this.transform);
        }
        if (RNG == 4)
        {
            Instantiate(KAR4, this.transform);
        }
        if (RNG == 5)
        {
            Instantiate(KAR5, this.transform);
        }
        if (RNG == 6)
        {
            Instantiate(KAR6, this.transform);
        }
        if (RNG == 7)
        {
            Instantiate(KAR7, this.transform);
        }
        if (RNG == 8)
        {
            Instantiate(KAR8, this.transform);
        }
        if (RNG == 9)
        {
            Instantiate(KAR9, this.transform);
        }
        if (RNG == 10)
        {
            Instantiate(KAR10, this.transform);
        }
        if (RNG == 11)
        {
            Instantiate(KAR11, this.transform);
        }
        if (RNG == 12)
        {
            Instantiate(KAR12, this.transform);
        }
    }
    void Update()
    {
        this.transform.Rotate(0f, RotationSpeed * Time.deltaTime, 0f);
        if (this.transform.eulerAngles.y >= 135)
        {
            ResetRotation();
            RNG = Random.Range(1, 13);
            if (RNG == 1)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR1, this.transform);
            }
            if (RNG == 2)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR2, this.transform);
            }
            if (RNG == 3)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR3, this.transform);
            }
            if (RNG == 4)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR4, this.transform);
            }
            if (RNG == 5)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR5, this.transform);
            }
            if (RNG == 6)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR6, this.transform);
            }
            if (RNG == 7)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR7, this.transform);
            }
            if (RNG == 8)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR8, this.transform);
            }
            if (RNG == 9)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR9, this.transform);
            }
            if (RNG == 10)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR10, this.transform);
            }
            if (RNG == 11)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR11, this.transform);
            }
            if (RNG == 12)
            {
                Destroy(this.transform.GetChild(0).gameObject);
                Instantiate(KAR12, this.transform);
            }
        }
    }
    public void ResetRotation()
    {
        this.transform.rotation = Quaternion.Euler(0f, ResetAngle, 0f);
    }
}
