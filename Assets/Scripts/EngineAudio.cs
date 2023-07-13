using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineAudio : MonoBehaviour
{
    public bool RE = true;
    public AudioSource runningSound;
    public float runningMaxVolume;
    public float runningMaxPitch;
    public AudioSource idleSound;
    public float idleMaxVolume;
    private float speedRatio;
    private float revLimiter;
    public float LimiterSound = 1f;
    public float LimiterFrequency = 3f;
    public float LimiterEngage = 0.8f;
    public bool isEngineRunning = false;
    public AudioSource startingSound;
    private CarController carController;
    void Start()
    {
        if (RE == false)
        {
            StartEngine();
        }
        carController = GetComponent<CarController>();
        idleSound.volume = 0;
        runningSound.volume = 0;
    }
    void Update()
    {
        if (RE)
        {
            if (carController)
            {
                speedRatio = carController.GetSpeedRatio();
            }
            if (speedRatio > LimiterEngage)
            {
                revLimiter = (Mathf.Sin(Time.time * LimiterFrequency) + 1f) * LimiterSound * (speedRatio - LimiterEngage);
            }
            if (isEngineRunning)
            {
                idleSound.volume = Mathf.Lerp(0.1f, idleMaxVolume, carController.RPM / 1000000f);
                runningSound.volume = Mathf.Lerp(0.3f, runningMaxVolume, carController.RPM / 1000000f);
                runningSound.pitch = Mathf.Lerp(0.3f, runningMaxPitch, carController.RPM / 2000000f);
            }
            else
            {
                idleSound.volume = 0;
                runningSound.volume = 0;
            }
        }
    }
    public IEnumerator StartEngine()
    {
        if (RE)
        {
            startingSound.Play();
        }
        carController.isEngineRunning = 1;
        yield return new WaitForSeconds(0.6f);
        isEngineRunning = true;
        yield return new WaitForSeconds(0.4f);
        carController.isEngineRunning = 2;
    }
}
