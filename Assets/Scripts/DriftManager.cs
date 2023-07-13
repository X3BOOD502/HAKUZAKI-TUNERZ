using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;

public class DriftManager : MonoBehaviour
{
    public bool CAR1;
    public bool CAR2;
    public bool CAR3;
    public bool CAR4;
    public ModdingList LIST;
    public ModdingList1 LIST1;
    public ModdingList2 LIST2;
    public ModdingList3 LIST3;
    public Rigidbody playerRB;
    public TMP_Text currentScoreText;
    public TMP_Text factorText;

    private float speed = 0;
    private float driftingAngle = 0;
    private float driftFactor = 1;
    private float currentScore;
    private float totalScore;

    private bool isDrifting = false;
    public float minimumSpeed = 5;
    public float minimumAngle = 10;
    public float driftingDelay = 0.2f;
    public GameObject driftingObject;
    public Image driftingBackground1;
    public Image driftingBackground2;
    public Color normalDriftColor;
    public Color nearStopColor;
    public Color driftEndedColor;

    private IEnumerator stopDriftingCoroutine = null;
    void Start()
    {
        
    }
    void Update()
    {
        ManageDrift();
        ManageUI();
    }
    void ManageDrift()
    {
        speed = playerRB.velocity.magnitude;
        driftingAngle = Vector3.Angle(playerRB.transform.forward, (playerRB.velocity + playerRB.transform.forward).normalized);
        if (driftingAngle > 120)
        {
            driftingAngle = 0;
        }
        if (driftingAngle > minimumAngle && speed > minimumSpeed)
        {
            if (!isDrifting || stopDriftingCoroutine != null)
            {
                StartDrift();
            }
        }
        else
        {
            if (isDrifting && stopDriftingCoroutine == null)
            {
                StopDrift();
            }
        }
        if (isDrifting)
        {
            currentScore += Time.deltaTime * driftingAngle * driftFactor;
            driftFactor += Time.deltaTime;
            driftingObject.SetActive(true);
        }
    }
    async void StartDrift()
    {
        if (!isDrifting)
        {
            await Task.Delay(Mathf.RoundToInt(1000 * driftingDelay));
            driftFactor = 1;
            isDrifting = true;
        }
        if (stopDriftingCoroutine != null)
        {
            StopCoroutine(stopDriftingCoroutine);
            stopDriftingCoroutine = null;
        }
        driftingBackground1.color = normalDriftColor;
        driftingBackground2.color = normalDriftColor;
        isDrifting = true;
    }
    void StopDrift()
    {
        stopDriftingCoroutine = StoppingDrift();
        StartCoroutine(stopDriftingCoroutine);
    }
    private IEnumerator StoppingDrift()
    {
        yield return new WaitForSeconds(0.1f);
        driftingBackground1.color = nearStopColor;
        driftingBackground2.color = nearStopColor;
        yield return new WaitForSeconds(driftingDelay * 4f);
        totalScore = currentScore;
        isDrifting = false;
        driftingBackground1.color = driftEndedColor;
        driftingBackground2.color = driftEndedColor;
        yield return new WaitForSeconds(0.5f);
        if (CAR1) { LIST.coins += (totalScore / 10); }
        if (CAR2) { LIST1.coins += (totalScore / 10); }
        if (CAR3) { LIST2.coins += (totalScore / 10); }
        if (CAR4) { LIST3.coins += (totalScore / 10); }
        currentScore = 0;
        driftingObject.SetActive(false);
    }
    void ManageUI()
    {
        factorText.text = driftFactor.ToString("###,###,##0,0") + "x";
        currentScoreText.text = currentScore.ToString("###,###,000");
    }
}
