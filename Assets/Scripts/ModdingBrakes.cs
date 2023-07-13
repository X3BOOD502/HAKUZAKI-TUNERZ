using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModdingBrakes : MonoBehaviour
{
    public CarController carController;
    public float BOOST;
    void Start()
    {
        addpowah();
    }
    public void addpowah()
    {
        carController.brakePower += BOOST;
    }
}
