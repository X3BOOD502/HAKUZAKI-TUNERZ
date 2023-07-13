using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed = 30f;
    public float ResetAngle = 135f;
    void Update()
    {
        this.transform.Rotate(0f, RotationSpeed * Time.deltaTime, 0f);
    }
    public void ResetRotation()
    {
        this.transform.rotation = Quaternion.Euler(0f, ResetAngle, 0f);
    }
}
