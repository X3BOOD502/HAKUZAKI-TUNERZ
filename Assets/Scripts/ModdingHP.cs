using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModdingHP : MonoBehaviour
{
    public CarController carController;
    public float BOOST;
    void Start()
    {
        addpowah();
    }
    public void addpowah()
    {
        carController.motorPower += BOOST;
    }
}
