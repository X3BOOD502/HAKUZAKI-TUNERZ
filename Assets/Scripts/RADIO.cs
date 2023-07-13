using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RADIO : MonoBehaviour
{
    public float SPEED = 1.0f;
    public Text COUNTER;
    public bool RAD = true;
    public float CHANNEL = 1f;
    public GameObject OFF;
    public GameObject ALL;

    public GameObject S1;
    public GameObject S2;
    public GameObject S3;
    public GameObject S4;
    public GameObject S5;
    public GameObject S6;
    public GameObject S7;
    public GameObject S8;
    public GameObject S9;
    public GameObject S10;
    public GameObject S11;
    public GameObject S12;
    public GameObject S13;
    public GameObject S14;
    public GameObject S15;
    public GameObject S16;
    public GameObject S17;
    public GameObject S18;
    public GameObject S19;
    public GameObject S20;
    public GameObject S21;
    public GameObject S22;
    public GameObject S23;
    public GameObject S24;
    public GameObject S25;
    public GameObject S26;
    public GameObject S27;
    public GameObject S28;
    public GameObject S29;
    public GameObject S30;
    public GameObject S31;
    public GameObject S32;
    public GameObject S33;
    public GameObject S34;
    public GameObject S35;
    public GameObject S36;
    public GameObject S37;
    public GameObject S38;
    public GameObject S39;
    public GameObject S40;
    public GameObject S41;
    public GameObject S42;
    public GameObject S43;
    public GameObject S44;
    public GameObject S45;
    public GameObject S46;
    public GameObject S47;
    public GameObject S48;
    public GameObject S49;
    public GameObject S50;

    public AudioSource D1;
    public AudioSource D2;
    public AudioSource D3;
    public AudioSource D4;
    public AudioSource D5;
    public AudioSource D6;
    public AudioSource D7;
    public AudioSource D8;
    public AudioSource D9;
    public AudioSource D10;
    public AudioSource D11;
    public AudioSource D12;
    public AudioSource D13;
    public AudioSource D14;
    public AudioSource D15;
    public AudioSource D16;
    public AudioSource D17;
    public AudioSource D18;
    public AudioSource D19;
    public AudioSource D20;
    public AudioSource D21;
    public AudioSource D22;
    public AudioSource D23;
    public AudioSource D24;
    public AudioSource D25;
    public AudioSource D26;
    public AudioSource D27;
    public AudioSource D28;
    public AudioSource D29;
    public AudioSource D30;
    public AudioSource D31;
    public AudioSource D32;
    public AudioSource D33;
    public AudioSource D34;
    public AudioSource D35;
    public AudioSource D36;
    public AudioSource D37;
    public AudioSource D38;
    public AudioSource D39;
    public AudioSource D40;
    public AudioSource D41;
    public AudioSource D42;
    public AudioSource D43;
    public AudioSource D44;
    public AudioSource D45;
    public AudioSource D46;
    public AudioSource D47;
    public AudioSource D48;
    public AudioSource D49;
    public AudioSource D50;

    public void RESET()
    {
        S1.SetActive(false);
        S2.SetActive(false);
        S3.SetActive(false);
        S4.SetActive(false);
        S5.SetActive(false);
        S6.SetActive(false);
        S7.SetActive(false);
        S8.SetActive(false);
        S9.SetActive(false);
        S10.SetActive(false);
        S11.SetActive(false);
        S12.SetActive(false);
        S13.SetActive(false);
        S14.SetActive(false);
        S15.SetActive(false);
        S16.SetActive(false);
        S17.SetActive(false);
        S18.SetActive(false);
        S19.SetActive(false);
        S20.SetActive(false);
        S21.SetActive(false);
        S22.SetActive(false);
        S23.SetActive(false);
        S24.SetActive(false);
        S25.SetActive(false);
        S26.SetActive(false);
        S27.SetActive(false);
        S28.SetActive(false);
        S29.SetActive(false);
        S30.SetActive(false);
        S31.SetActive(false);
        S32.SetActive(false);
        S33.SetActive(false);
        S34.SetActive(false);
        S35.SetActive(false);
        S36.SetActive(false);
        S37.SetActive(false);
        S38.SetActive(false);
        S39.SetActive(false);
        S40.SetActive(false);
        S41.SetActive(false);
        S42.SetActive(false);
        S43.SetActive(false);
        S44.SetActive(false);
        S45.SetActive(false);
        S46.SetActive(false);
        S47.SetActive(false);
        S48.SetActive(false);
        S49.SetActive(false);
        S50.SetActive(false);
    }

    public void PITCH()
    {
        D1.pitch = SPEED;
        D2.pitch = SPEED;
        D3.pitch = SPEED;
        D4.pitch = SPEED;
        D5.pitch = SPEED;
        D6.pitch = SPEED;
        D7.pitch = SPEED;
        D8.pitch = SPEED;
        D9.pitch = SPEED;
        D10.pitch = SPEED;
        D11.pitch = SPEED;
        D12.pitch = SPEED;
        D13.pitch = SPEED;
        D14.pitch = SPEED;
        D15.pitch = SPEED;
        D16.pitch = SPEED;
        D17.pitch = SPEED;
        D18.pitch = SPEED;
        D19.pitch = SPEED;
        D20.pitch = SPEED;
        D21.pitch = SPEED;
        D22.pitch = SPEED;
        D23.pitch = SPEED;
        D24.pitch = SPEED;
        D25.pitch = SPEED;
        D26.pitch = SPEED;
        D27.pitch = SPEED;
        D28.pitch = SPEED;
        D29.pitch = SPEED;
        D30.pitch = SPEED;
        D31.pitch = SPEED;
        D32.pitch = SPEED;
        D33.pitch = SPEED;
        D34.pitch = SPEED;
        D35.pitch = SPEED;
        D36.pitch = SPEED;
        D37.pitch = SPEED;
        D38.pitch = SPEED;
        D39.pitch = SPEED;
        D40.pitch = SPEED;
        D41.pitch = SPEED;
        D42.pitch = SPEED;
        D43.pitch = SPEED;
        D44.pitch = SPEED;
        D45.pitch = SPEED;
        D46.pitch = SPEED;
        D47.pitch = SPEED;
        D48.pitch = SPEED;
        D49.pitch = SPEED;
        D50.pitch = SPEED;
    }

    void Update()
    {
        if (SPEED < 0.1f)
        {
            SPEED = 0.1f;
            PITCH();
        }
        if (SPEED > 3.0f)
        {
            SPEED = 3.0f;
            PITCH();
        }



        if (Input.GetKeyDown(KeyCode.Z))
        {
            SPEED -= 0.1f;
            PITCH();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SPEED += 0.1f;
            PITCH();
        }



        COUNTER.text = "" + SPEED;
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (RAD == true)
            {
                ALL.SetActive(false);
                OFF.SetActive(true);
                RAD = false;
            }
            else
            {
                ALL.SetActive(true);
                OFF.SetActive(false);
                RAD = true;
            }
        }



        if (CHANNEL <= 0f)
        {
            CHANNEL = 50f;
        }
        if (CHANNEL >= 51f)
        {
            CHANNEL = 1f;
        }



        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            RESET();
            CHANNEL -= 1f;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            RESET();
            CHANNEL += 1f;
        }



        if (CHANNEL == 1f)
        {
            S1.SetActive(true);
            if (D1.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 2f)
        {
            S2.SetActive(true);
            if (D2.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 3f)
        {
            S3.SetActive(true);
            if (D3.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 4f)
        {
            S4.SetActive(true);
            if (D4.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 5f)
        {
            S5.SetActive(true);
            if (D5.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 6f)
        {
            S6.SetActive(true);
            if (D6.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 7f)
        {
            S7.SetActive(true);
            if (D7.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 8f)
        {
            S8.SetActive(true);
            if (D8.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 9f)
        {
            S9.SetActive(true);
            if (D9.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 10f)
        {
            S10.SetActive(true);
            if (D10.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 11f)
        {
            S11.SetActive(true);
            if (D11.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 12f)
        {
            S12.SetActive(true);
            if (D12.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 13f)
        {
            S13.SetActive(true);
            if (D13.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 14f)
        {
            S14.SetActive(true);
            if (D14.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 15f)
        {
            S15.SetActive(true);
            if (D15.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 16f)
        {
            S16.SetActive(true);
            if (D16.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 17f)
        {
            S17.SetActive(true);
            if (D17.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 18f)
        {
            S18.SetActive(true);
            if (D18.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 19f)
        {
            S19.SetActive(true);
            if (D19.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 20f)
        {
            S20.SetActive(true);
            if (D20.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 21f)
        {
            S21.SetActive(true);
            if (D21.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 22f)
        {
            S22.SetActive(true);
            if (D22.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 23f)
        {
            S23.SetActive(true);
            if (D23.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 24f)
        {
            S24.SetActive(true);
            if (D24.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 25f)
        {
            S25.SetActive(true);
            if (D25.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 26f)
        {
            S26.SetActive(true);
            if (D26.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 27f)
        {
            S27.SetActive(true);
            if (D27.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 28f)
        {
            S28.SetActive(true);
            if (D28.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 29f)
        {
            S29.SetActive(true);
            if (D29.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 30f)
        {
            S30.SetActive(true);
            if (D30.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 31f)
        {
            S31.SetActive(true);
            if (D31.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 32f)
        {
            S32.SetActive(true);
            if (D32.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 33f)
        {
            S33.SetActive(true);
            if (D33.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 34f)
        {
            S34.SetActive(true);
            if (D34.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 35f)
        {
            S35.SetActive(true);
            if (D35.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 36f)
        {
            S36.SetActive(true);
            if (D36.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 37f)
        {
            S37.SetActive(true);
            if (D37.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 38f)
        {
            S38.SetActive(true);
            if (D38.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 39f)
        {
            S39.SetActive(true);
            if (D39.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 40f)
        {
            S40.SetActive(true);
            if (D40.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 41f)
        {
            S41.SetActive(true);
            if (D41.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 42f)
        {
            S42.SetActive(true);
            if (D42.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 43f)
        {
            S43.SetActive(true);
            if (D43.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 44f)
        {
            S44.SetActive(true);
            if (D44.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 45f)
        {
            S45.SetActive(true);
            if (D45.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 46f)
        {
            S46.SetActive(true);
            if (D46.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 47f)
        {
            S47.SetActive(true);
            if (D47.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 48f)
        {
            S48.SetActive(true);
            if (D48.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 49f)
        {
            S49.SetActive(true);
            if (D49.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
        if (CHANNEL == 50f)
        {
            S50.SetActive(true);
            if (D50.isPlaying)
            { }
            else
            { RESET(); CHANNEL += 1f; }
        }
    }
}
