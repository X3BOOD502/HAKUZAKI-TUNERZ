using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shifting : MonoBehaviour
{
    public CarController carController;
    public bool NETURAL;
    public bool REVERSE;
    public bool FIRST;
    public bool SECOND;
    public bool THIRD;
    public bool FOURTH;
    public bool FIFTH;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SHIFTER")
        {
            if (NETURAL == true)
            {
                carController.NETURALIZE();
            }
            if (REVERSE == true)
            {
                carController.REVERSERIZE();
            }
            if (FIRST == true)
            {
                carController.currentGear = 0;
                carController.RUNNERIZE();
            }
            if (SECOND == true)
            {
                carController.currentGear = 1;
                carController.RUNNERIZE();
            }
            if (THIRD == true)
            {
                carController.currentGear = 2;
                carController.RUNNERIZE();
            }
            if (FOURTH == true)
            {
                carController.currentGear = 3;
                carController.RUNNERIZE();
            }
            if (FIFTH == true)
            {
                carController.currentGear = 4;
                carController.RUNNERIZE();
            }
        }
    }
}
