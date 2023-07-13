using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public enum GearState
{
    Neutral,
    Reverse,
    Running,
    CheckingChange,
    Changing
}
public class CarController : MonoBehaviour
{
    private bool IHAD = true;
    private bool IHAV = true;
    public TMP_Text TIMEZ;
    public float C_GEAR;
    public bool ISRACING = false;
    public bool RE = true;
    public float R_TIMER = 10f;
    public bool UNGARAGED = true;
    public Rigidbody playerRB;
    public bool AUTOMATIC;
    public bool FWD;
    public bool RWD;
    public bool AWD;
    public Vector3 center;
    public WheelColliders colliders;
    public WheelMeshes wheelMeshes;
    public WheelBrakes wheelBrakes;
    public WheelParticles wheelParticles;
    public float gasInput;
    public float brakeInput;
    public float steeringInput;
    public GameObject SmokePrefab;
    public float motorPower;
    public float brakePower;
    public AnimationCurve steeringCurve;
    private float slipAngle;
    private float speed;
    private float speedClamped;
    public float maxSpeed;
    public int isEngineRunning;
    public float RPM;
    public float redLine;
    public float idleRPM;
    public TMP_Text rpmText;
    public TMP_Text gearText;
    public TMP_Text speedText;
    public TMP_Text hpText;
    public Transform rpmNeedle;
    public Transform speedNeedle;
    public float MinNeedleRotation;
    public float MaxNeedleRotation;
    public int currentGear;
    public float[] gearRatios;
    public float diffrentialRatio;
    public AnimationCurve hpToRpmCurve;
    public float increaseGearRPM;
    public float decreaseGearRPM;
    public float changeGearTime = 0.5f;
    public GameObject SHIFTINGZONE;
    private GearState gearState;
    private float currentTorque;
    private float clutch;
    private float wheelRPM;
    private float currentSpeed;
    public void NETURALIZE()
    {
        gearState = GearState.Neutral;
    }
    public void REVERSERIZE()
    {
        gearState = GearState.Reverse;
    }
    public void RUNNERIZE()
    {
        gearState = GearState.Running;
    }
    void Start()
    {
        Application.targetFrameRate = 60;
        if (UNGARAGED)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            playerRB.centerOfMass = center;
            InstantiateSmoke();
        }
    }
    void InstantiateSmoke()
    {
        wheelParticles.FRWheel = Instantiate(SmokePrefab, colliders.FRWheel.transform.position - Vector3.up * colliders.FRWheel.radius, Quaternion.identity, colliders.FRWheel.transform).GetComponent<ParticleSystem>();
        wheelParticles.FLWheel = Instantiate(SmokePrefab, colliders.FLWheel.transform.position - Vector3.up * colliders.FLWheel.radius, Quaternion.identity, colliders.FLWheel.transform).GetComponent<ParticleSystem>();
        wheelParticles.RRWheel = Instantiate(SmokePrefab, colliders.RRWheel.transform.position - Vector3.up * colliders.RRWheel.radius, Quaternion.identity, colliders.RRWheel.transform).GetComponent<ParticleSystem>();
        wheelParticles.RLWheel = Instantiate(SmokePrefab, colliders.RLWheel.transform.position - Vector3.up * colliders.RLWheel.radius, Quaternion.identity, colliders.RLWheel.transform).GetComponent<ParticleSystem>();
    }
    void Update()
    {
        if (ISRACING)
        {
            if (R_TIMER <= 0f)
            {
                if (IHAV)
                {
                    Destroy(TIMEZ.transform.parent.gameObject);
                    IHAV = false;
                }
                if (IHAV == false)
                {
                    if (IHAD)
                    {
                        RUNNERIZE();
                        IHAD = false;
                    }
                }
            }
            else
            {
                TIMEZ.text = R_TIMER.ToString("0.0") + "";
                R_TIMER -= 1f * Time.deltaTime;
            }
        }
        if (RE == false)
        {
            if (R_TIMER <= 0f)
            {
                isEngineRunning = 2;
                RUNNERIZE();
                gasInput = 1;
            }
            else
            {
                R_TIMER -= 1f * Time.deltaTime;
            }
            if (currentGear == 0)
            {
                C_GEAR = 1;
            }
            if (currentGear == 1)
            {
                C_GEAR = 2;
            }
            if (currentGear == 2)
            {
                C_GEAR = 3;
            }
            if (currentGear == 3)
            {
                C_GEAR = 4;
            }
            if (currentGear == 4)
            {
                C_GEAR = 5;
            }
        }
        if (UNGARAGED)
        {
            rpmNeedle.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(MinNeedleRotation, MaxNeedleRotation, RPM / (redLine * 1.1f)));
            speedNeedle.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(MinNeedleRotation, MaxNeedleRotation, currentSpeed / (200f)));
            rpmText.text = RPM.ToString("0000") + "";
            speedText.text = currentSpeed.ToString("000") + "";
            hpText.text = motorPower + "";
            gearText.text = (gearState == GearState.Neutral) ? "N" : (gearState == GearState.Reverse) ? "R" : (currentGear + 1).ToString();
            speed = colliders.FRWheel.rpm * colliders.FRWheel.radius * 2f * Mathf.PI / 10f;
            speedClamped = Mathf.Lerp(speedClamped, speed, Time.deltaTime);
            currentSpeed = (playerRB.velocity.magnitude) * 3;
            ApplyWheelPoitions();
            ApplyWheelBrakesPoitions();
            ApplyMotor();
            ApplySteering();
            ApplyBrake();
            CheckParticles();
            CheckInput();
            if (AUTOMATIC)
            {
                SHIFTINGZONE.SetActive(false);
            }
            else
            {
                SHIFTINGZONE.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                this.gameObject.transform.eulerAngles = new Vector3(0.0f, Random.Range(0.0f, 360.0f), 0.0f);
                this.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
            }
        }
        else
        {
            ApplyWheelPoitions();
            ApplyWheelBrakesPoitions();
        }
    }
    void CheckInput()
    {
        if (UNGARAGED)
        {
            if (RE)
            {
                if (ISRACING)
                {
                    if (R_TIMER <= 0f)
                    {
                        gasInput = Input.GetAxis("Vertical");
                        steeringInput = Input.GetAxis("Horizontal");
                    }
                }
                else
                {
                    gasInput = Input.GetAxis("Vertical");
                    steeringInput = Input.GetAxis("Horizontal");
                }
            }
            slipAngle = Vector3.Angle(transform.forward, playerRB.velocity);
            if (gearState != GearState.Changing)
            {
                if (gearState == GearState.Neutral)
                {
                    clutch = 0;
                    if (gasInput > 0) gearState = GearState.Running;
                }
                else
                {
                    clutch = Input.GetKey(KeyCode.LeftShift) ? 0 : Mathf.Lerp(clutch, 1, Time.deltaTime);
                }
            }
            else
            {
                clutch = 0;
            }
            if (slipAngle < 120f)
            {
                if (gasInput < 0)
                {
                    brakeInput = Mathf.Abs(gasInput);
                    gasInput = 0;
                }
                else if (Input.GetKey(KeyCode.Space))
                {
                    brakeInput = Mathf.Abs(0.5f);
                    gasInput = 0;
                }
                else
                {
                    brakeInput = 0;
                }
            }
            if (Mathf.Abs(gasInput) > 0 && isEngineRunning == 0)
            {
                StartCoroutine(GetComponent<EngineAudio>().StartEngine());
                gearState = GearState.Running;
            }
        }
    }
    void ApplyBrake()
    {
        colliders.FRWheel.brakeTorque = brakeInput * brakePower * 0.7f;
        colliders.FLWheel.brakeTorque = brakeInput * brakePower * 0.7f;
        colliders.RRWheel.brakeTorque = brakeInput * brakePower * 0.3f;
        colliders.RLWheel.brakeTorque = brakeInput * brakePower * 0.3f;
    }
    void ApplyMotor()
    {
        if (isEngineRunning > 1)
        {
            if (FWD)
            {
                currentTorque = CalculateTorque();
                colliders.FRWheel.motorTorque = currentTorque * gasInput;
                colliders.FLWheel.motorTorque = currentTorque * gasInput;
            }
            if (RWD)
            {
                currentTorque = CalculateTorque();
                colliders.RRWheel.motorTorque = currentTorque * gasInput;
                colliders.RLWheel.motorTorque = currentTorque * gasInput;
            }
            if (AWD)
            {
                currentTorque = CalculateTorque();
                colliders.FRWheel.motorTorque = currentTorque * gasInput;
                colliders.FLWheel.motorTorque = currentTorque * gasInput;
                colliders.RRWheel.motorTorque = currentTorque * gasInput;
                colliders.RLWheel.motorTorque = currentTorque * gasInput;
            }
        }
    }
    float CalculateTorque()
    {
        float torque = 0;
        if (AUTOMATIC)
        {
            if (RPM < idleRPM + 200 && gasInput == 0 && currentGear == 0)
            {
                gearState = GearState.Neutral;
            }
            if (gearState == GearState.Running && clutch > 0)
            {
                if (RPM > increaseGearRPM)
                {
                    StartCoroutine(ChangeGear(1));
                }
                else if (RPM < decreaseGearRPM)
                {
                    StartCoroutine(ChangeGear(-1));
                }
            }
        }
        if (isEngineRunning > 0)
        {
            if (clutch < 0.1f)
            {
                RPM = Mathf.Lerp(RPM, Mathf.Max(idleRPM, redLine * gasInput) + Random.Range(-50, 50), Time.deltaTime);
            }
            else
            {
                wheelRPM = Mathf.Abs((colliders.FRWheel.rpm + colliders.FLWheel.rpm) / 2f) * gearRatios[currentGear] * diffrentialRatio;
                RPM = Mathf.Lerp(RPM, Mathf.Max(idleRPM - 100, wheelRPM), Time.deltaTime * 3f);
                if (gearState == GearState.Reverse)
                {
                    torque = (hpToRpmCurve.Evaluate(RPM / redLine) * -motorPower / RPM) * gearRatios[currentGear] * diffrentialRatio * 5252f * clutch;
                }
                else
                {
                    torque = (hpToRpmCurve.Evaluate(RPM / redLine) * motorPower / RPM) * gearRatios[currentGear] * diffrentialRatio * 5252f * clutch;
                }
            }
        }
        return torque;
    }
    void ApplySteering()
    {
        float steeringAngle = steeringInput * steeringCurve.Evaluate(speed);
        colliders.FRWheel.steerAngle = steeringAngle;
        colliders.FLWheel.steerAngle = steeringAngle;
    }
    void ApplyWheelPoitions()
    {
        UpdateWheel(colliders.FRWheel, wheelMeshes.FRWheel);
        UpdateWheel(colliders.FLWheel, wheelMeshes.FLWheel);
        UpdateWheel(colliders.RRWheel, wheelMeshes.RRWheel);
        UpdateWheel(colliders.RLWheel, wheelMeshes.RLWheel);
    }
    void ApplyWheelBrakesPoitions()
    {
        UpdateWheelBrakes(colliders.FRWheel, wheelBrakes.FRWheel);
        UpdateWheelBrakes(colliders.FLWheel, wheelBrakes.FLWheel);
        UpdateWheelBrakes(colliders.RRWheel, wheelBrakes.RRWheel);
        UpdateWheelBrakes(colliders.RLWheel, wheelBrakes.RLWheel);
    }
    void CheckParticles()
    {
        WheelHit[] wheelHits = new WheelHit[4];
        colliders.FRWheel.GetGroundHit(out wheelHits[0]);
        colliders.FLWheel.GetGroundHit(out wheelHits[1]);
        colliders.RRWheel.GetGroundHit(out wheelHits[2]);
        colliders.RLWheel.GetGroundHit(out wheelHits[3]);
        float slipAllowance = 0.1f;
        if ((Mathf.Abs(wheelHits[0].sidewaysSlip) + Mathf.Abs(wheelHits[0].forwardSlip) > slipAllowance))
        {
            wheelParticles.FRWheel.Play();
        }
        else
        {
            wheelParticles.FRWheel.Stop();
        }
        if ((Mathf.Abs(wheelHits[1].sidewaysSlip) + Mathf.Abs(wheelHits[1].forwardSlip) > slipAllowance))
        {
            wheelParticles.FLWheel.Play();
        }
        else
        {
            wheelParticles.FLWheel.Stop();
        }
        if ((Mathf.Abs(wheelHits[2].sidewaysSlip) + Mathf.Abs(wheelHits[2].forwardSlip) > slipAllowance))
        {
            wheelParticles.RRWheel.Play();
        }
        else
        {
            wheelParticles.RRWheel.Stop();
        }
        if ((Mathf.Abs(wheelHits[3].sidewaysSlip) + Mathf.Abs(wheelHits[3].forwardSlip) > slipAllowance))
        {
            wheelParticles.RLWheel.Play();
        }
        else
        {
            wheelParticles.RLWheel.Stop();
        }
    }
    void UpdateWheel(WheelCollider coll,MeshRenderer wheelMesh)
    {
        Quaternion quat;
        Vector3 position;
        coll.GetWorldPose(out position, out quat);
        wheelMesh.transform.position = position;
        wheelMesh.transform.rotation = quat;
    }
    public float GetSpeedRatio()
    {
        var gas = Mathf.Clamp(gasInput, 0.5f, 1f);
        return speedClamped = gas / redLine;
    }
    IEnumerator ChangeGear(int gearChange)
    {
        gearState = GearState.CheckingChange;
        if (currentGear + gearChange >= 0)
        {
            if (gearChange > 0)
            {
                yield return new WaitForSeconds(0.7f);
                if (RPM<increaseGearRPM || currentGear >= gearRatios.Length - 1)
                {
                    gearState = GearState.Running;
                    yield break;
                }
            }
            if (gearChange < 0)
            {
                yield return new WaitForSeconds(0.1f);
                if (RPM > decreaseGearRPM || currentGear <= 0)
                {
                    gearState = GearState.Running;
                    yield break;
                }
            }
            gearState = GearState.Changing;
            yield return new WaitForSeconds(changeGearTime);
            currentGear += gearChange;
        }
        if (gearState != GearState.Neutral)
        {

        }
        gearState = GearState.Running;
    }
    void UpdateWheelBrakes(WheelCollider coll, MeshRenderer wheelMesh)
    {
        Quaternion quat;
        Vector3 position;
        coll.GetWorldPose(out position, out quat);
        wheelMesh.transform.position = position;
    }
}
[System.Serializable]
public class WheelColliders
{
    public WheelCollider FRWheel;
    public WheelCollider FLWheel;
    public WheelCollider RRWheel;
    public WheelCollider RLWheel;
}
[System.Serializable]
public class WheelMeshes
{
    public MeshRenderer FRWheel;
    public MeshRenderer FLWheel;
    public MeshRenderer RRWheel;
    public MeshRenderer RLWheel;
}
[System.Serializable]
public class WheelParticles
{
    public ParticleSystem FRWheel;
    public ParticleSystem FLWheel;
    public ParticleSystem RRWheel;
    public ParticleSystem RLWheel;
}
[System.Serializable]
public class WheelBrakes
{
    public MeshRenderer FRWheel;
    public MeshRenderer FLWheel;
    public MeshRenderer RRWheel;
    public MeshRenderer RLWheel;
}