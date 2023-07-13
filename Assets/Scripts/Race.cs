using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race : MonoBehaviour
{
    public float FRIENDLYS = 0;
    public float OPPONENTS = 0;
    public float WINLIMIT = 1;
    public GameObject VICTORY;
    public GameObject DEFEAT;
    void Start()
    {
        VICTORY.SetActive(false);
        DEFEAT.SetActive(false);
    }
    void Update()
    {
        if (FRIENDLYS >= WINLIMIT)
        {
            VICTORY.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 1;
            Destroy(this.gameObject);
        }
        if (OPPONENTS >= WINLIMIT)
        {
            DEFEAT.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 1;
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FRND")
        {
            Destroy(other.transform.parent.parent.gameObject);
            FRIENDLYS += 1;
        }
        if (other.gameObject.tag == "ENMY")
        {
            Destroy(other.transform.parent.parent.gameObject);
            OPPONENTS += 1;
        }
    }
}
