using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GarageList : MonoBehaviour
{
    /// <summary>
    /// UPDATE (ISHOOD) iNSTEAD OF (hood) WHEN SAVING AND LOADING
    /// UPDATE (SSSbodyMETAL.value) INSTEAD OF (bodyMETAL) WHEN SAVING, DO THIS TO ALL OTHER COLORS TOO ;)
    /// </summary>
    public float MAPSELECT = 0;
    public GameObject LOADING;
    public bool NEWSAVE;
    /// EZ GAZI PRODUKTIONZ
    public bool WASHOOD;
    public bool ISHOOD;
    public GameObject KAR1;
    public GameObject KAR2;
    public GameObject KAR3;
    public GameObject KAR4;
    public TMP_Text Coins;
    public TMP_Text HorsePower;
    public Rotator ROTATOR1;
    public Rotator ROTATOR2;
    public Transform SPAWNER;
    public GameObject DAIHATSU;
    public GameObject SUZUKI;
    public GameObject TOYOTA;
    public GameObject NISSAN;
    public bool ZZZDAIHATSU;
    public bool ZZZSUZUKI;
    public bool ZZZTOYOTA;
    public bool ZZZNISSAN;
    public ModdingList LIST1;
    public ModdingList1 LIST2;
    public ModdingList2 LIST3;
    public ModdingList3 LIST4;
    public CarController CARCONTROLLER;
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    public float bodyMETAL;
    public float bodyR;
    public float bodyG;
    public float bodyB;
    /// EZ GAZI PRODUKTIONZ
    public float engineMETAL;
    public float engineR;
    public float engineG;
    public float engineB;
    /// EZ GAZI PRODUKTIONZ
    public float wheelsMETAL;
    public float wheelsR;
    public float wheelsG;
    public float wheelsB;
    /// EZ GAZI PRODUKTIONZ
    public float coins;
    /// EZ GAZI PRODUKTIONZ
    public bool hood;
    public bool stockbody;
    public bool widebody;
    public bool spoiler;
    public bool brakesLVL1;
    public bool brakesLVL2;
    public bool brakesLVL3;
    public bool exhaustLVL1;
    public bool exhaustLVL2;
    public bool exhaustLVL3;
    public bool intakeLVL1;
    public bool intakeLVL2;
    public bool intakeLVL3;
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    public Slider SSSbodyMETAL;
    public Slider SSSbodyR;
    public Slider SSSbodyG;
    public Slider SSSbodyB;
    public Slider SSSengineMETAL;
    public Slider SSSengineR;
    public Slider SSSengineG;
    public Slider SSSengineB;
    public Slider SSSwheelsMETAL;
    public Slider SSSwheelsR;
    public Slider SSSwheelsG;
    public Slider SSSwheelsB;
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    public Button ButtonMIRA;
    public Button ButtonSAMURAI;
    public Button ButtonCAMRY;
    public Button Button180SX;
    /// EZ GAZI PRODUKTIONZ
    public Button ButtonSTOCKBODY;
    public Button ButtonHOOD;
    public Button ButtonHOODOFF;
    public Button ButtonSPOILEROFF;
    public Button ButtonSPOILER;
    public Button ButtonWIDEBODY;
    /// EZ GAZI PRODUKTIONZ
    public Button ButtonEXHAUSTLVL1;
    public Button ButtonEXHAUSTLVL2;
    public Button ButtonEXHAUSTLVL3;
    /// EZ GAZI PRODUKTIONZ
    public Button ButtonINTAKELVL1;
    public Button ButtonINTAKELVL2;
    public Button ButtonINTAKELVL3;
    /// EZ GAZI PRODUKTIONZ
    public Button ButtonBRAKESLVL1;
    public Button ButtonBRAKESLVL2;
    public Button ButtonBRAKESLVL3;
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    public bool boughtDAIHATSU;
    public bool boughtSUZUKI;
    public bool boughtTOYOTA;
    public bool boughtNISSAN;
    public bool boughtSPOILER;
    public bool boughtWIDEBODY;
    public bool boughtEXHAUSTLVL2;
    public bool boughtEXHAUSTLVL3;
    public bool boughtINTAKELVL2;
    public bool boughtINTAKELVL3;
    public bool boughtBRAKESLVL2;
    public bool boughtBRAKESLVL3;
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    public GameObject BuyDAIHATSU;
    public GameObject BuySUZUKI;
    public GameObject BuyTOYOTA;
    public GameObject BuyNISSAN;
    public GameObject BuySPOILER;
    public GameObject BuyWIDEBODY;
    public GameObject BuyEXHAUSTLVL2;
    public GameObject BuyEXHAUSTLVL3;
    public GameObject BuyINTAKELVL2;
    public GameObject BuyINTAKELVL3;
    public GameObject BuyBRAKESLVL2;
    public GameObject BuyBRAKESLVL3;
    /// EZ GAZI PRODUKTIONZ
    public AudioSource BUYSOUND;
    void Start()
    {
        if (NEWSAVE)
        {
            SaveSystem.SavePlayer(this);
        }
        else
        {
            PlayerData data = SaveSystem.LoadPlayer();
            ZZZDAIHATSU = data.ZZZDAIHATSU;
            ZZZSUZUKI = data.ZZZSUZUKI;
            ZZZTOYOTA = data.ZZZTOYOTA;
            ZZZNISSAN = data.ZZZNISSAN;
            SSSbodyMETAL.value = data.bodyMETAL;
            SSSbodyR.value = data.bodyR;
            SSSbodyG.value = data.bodyG;
            SSSbodyB.value = data.bodyB;
            SSSengineMETAL.value = data.engineMETAL;
            SSSengineR.value = data.engineR;
            SSSengineG.value = data.engineG;
            SSSengineB.value = data.engineB;
            SSSwheelsMETAL.value = data.wheelsMETAL;
            SSSwheelsR.value = data.wheelsR;
            SSSwheelsG.value = data.wheelsG;
            SSSwheelsB.value = data.wheelsB;
            coins = data.coins;
            ISHOOD = data.hood;
            stockbody = data.stockbody;
            widebody = data.widebody;
            spoiler = data.spoiler;
            brakesLVL1 = data.brakesLVL1;
            brakesLVL2 = data.brakesLVL2;
            brakesLVL3 = data.brakesLVL3;
            exhaustLVL1 = data.exhaustLVL1;
            exhaustLVL2 = data.exhaustLVL2;
            exhaustLVL3 = data.exhaustLVL3;
            intakeLVL1 = data.intakeLVL1;
            intakeLVL2 = data.intakeLVL2;
            intakeLVL3 = data.intakeLVL3;
            boughtDAIHATSU = data.boughtDAIHATSU;
            boughtSUZUKI = data.boughtSUZUKI;
            boughtTOYOTA = data.boughtTOYOTA;
            boughtNISSAN = data.boughtNISSAN;
            boughtSPOILER = data.boughtSPOILER;
            boughtWIDEBODY = data.boughtWIDEBODY;
            boughtEXHAUSTLVL2 = data.boughtEXHAUSTLVL2;
            boughtEXHAUSTLVL3 = data.boughtEXHAUSTLVL3;
            boughtINTAKELVL2 = data.boughtINTAKELVL2;
            boughtINTAKELVL3 = data.boughtINTAKELVL3;
            boughtBRAKESLVL2 = data.boughtBRAKESLVL2;
            boughtBRAKESLVL3 = data.boughtBRAKESLVL3;
        }
        if (ZZZDAIHATSU)
        {
            Instantiate(DAIHATSU, SPAWNER);
        }
        if (ZZZSUZUKI)
        {
            Instantiate(SUZUKI, SPAWNER);
        }
        if (ZZZTOYOTA)
        {
            Instantiate(TOYOTA, SPAWNER);
        }
        if (ZZZNISSAN)
        {
            Instantiate(NISSAN, SPAWNER);
        }
    }
    void Update()
    {
        bodyMETAL = SSSbodyMETAL.value;
        bodyR = SSSbodyR.value;
        bodyG = SSSbodyG.value;
        bodyB = SSSbodyB.value;
        engineMETAL = SSSengineMETAL.value;
        engineR = SSSengineR.value;
        engineG = SSSengineG.value;
        engineB = SSSengineB.value;
        wheelsMETAL = SSSwheelsMETAL.value;
        wheelsR = SSSwheelsR.value;
        wheelsG = SSSwheelsG.value;
        wheelsB = SSSwheelsB.value;
        /// EZ GAZI PRODUKTIONZ
        if (boughtDAIHATSU) { Destroy(BuyDAIHATSU); }
        if (boughtSUZUKI) { Destroy(BuySUZUKI); }
        if (boughtTOYOTA) { Destroy(BuyTOYOTA); }
        if (boughtNISSAN) { Destroy(BuyNISSAN); }
        if (boughtSPOILER) { Destroy(BuySPOILER); }
        if (boughtWIDEBODY) { Destroy(BuyWIDEBODY); }
        if (boughtEXHAUSTLVL2) { Destroy(BuyEXHAUSTLVL2); }
        if (boughtEXHAUSTLVL3) { Destroy(BuyEXHAUSTLVL3); }
        if (boughtINTAKELVL2) { Destroy(BuyINTAKELVL2); }
        if (boughtINTAKELVL3) { Destroy(BuyINTAKELVL3); }
        if (boughtBRAKESLVL2) { Destroy(BuyBRAKESLVL2); }
        if (boughtBRAKESLVL3) { Destroy(BuyBRAKESLVL3); }
        /// EZ GAZI PRODUKTIONZ
        CARCONTROLLER = SPAWNER.GetChild(0).transform.GetChild(1).transform.gameObject.GetComponent<CarController>();
        Coins.text = coins.ToString("000000") + "";
        if (CARCONTROLLER != null)
        {
            HorsePower.text = CARCONTROLLER.motorPower + "";
        }
        if (ZZZDAIHATSU)
        {
            KAR1.SetActive(true);
            KAR2.SetActive(false);
            KAR3.SetActive(false);
            KAR4.SetActive(false);
            ButtonMIRA.image.color = new Color(0f, 255f, 0f);
            ButtonSAMURAI.image.color = new Color(255f, 255f, 255f);
            ButtonCAMRY.image.color = new Color(255f, 255f, 255f);
            Button180SX.image.color = new Color(255f, 255f, 255f);
            LIST1 = SPAWNER.GetChild(0).transform.GetChild(1).transform.gameObject.GetComponent<ModdingList>();
            /// EZ GAZI PRODUKTIONZ
            LIST1.bodyMETAL = this.bodyMETAL;
            LIST1.bodyR = this.bodyR;
            LIST1.bodyG = this.bodyG;
            LIST1.bodyB = this.bodyB;
            /// EZ GAZI PRODUKTIONZ
            LIST1.engineMETAL = this.engineMETAL;
            LIST1.engineR = this.engineR;
            LIST1.engineG = this.engineG;
            LIST1.engineB = this.engineB;
            /// EZ GAZI PRODUKTIONZ
            LIST1.wheelsMETAL = this.wheelsMETAL;
            LIST1.wheelsR = this.wheelsR;
            LIST1.wheelsG = this.wheelsG;
            LIST1.wheelsB = this.wheelsB;
            /// EZ GAZI PRODUKTIONZ
            LIST1.hood = this.hood;
            LIST1.stockbody = this.stockbody;
            LIST1.widebody = this.widebody;
            LIST1.spoiler = this.spoiler;
            LIST1.brakesLVL1 = this.brakesLVL1;
            LIST1.brakesLVL2 = this.brakesLVL2;
            LIST1.brakesLVL3 = this.brakesLVL3;
            LIST1.exhaustLVL1 = this.exhaustLVL1;
            LIST1.exhaustLVL2 = this.exhaustLVL2;
            LIST1.exhaustLVL3 = this.exhaustLVL3;
            LIST1.intakeLVL1 = this.intakeLVL1;
            LIST1.intakeLVL2 = this.intakeLVL2;
            LIST1.intakeLVL3 = this.intakeLVL3;
        }
        if (ZZZSUZUKI)
        {
            KAR1.SetActive(false);
            KAR2.SetActive(true);
            KAR3.SetActive(false);
            KAR4.SetActive(false);
            ButtonMIRA.image.color = new Color(255f, 255f, 255f);
            ButtonSAMURAI.image.color = new Color(0f, 255f, 0f);
            ButtonCAMRY.image.color = new Color(255f, 255f, 255f);
            Button180SX.image.color = new Color(255f, 255f, 255f);
            LIST2 = SPAWNER.GetChild(0).transform.GetChild(1).transform.gameObject.GetComponent<ModdingList1>();
            /// EZ GAZI PRODUKTIONZ
            LIST2.bodyMETAL = this.bodyMETAL;
            LIST2.bodyR = this.bodyR;
            LIST2.bodyG = this.bodyG;
            LIST2.bodyB = this.bodyB;
            /// EZ GAZI PRODUKTIONZ
            LIST2.engineMETAL = this.engineMETAL;
            LIST2.engineR = this.engineR;
            LIST2.engineG = this.engineG;
            LIST2.engineB = this.engineB;
            /// EZ GAZI PRODUKTIONZ
            LIST2.wheelsMETAL = this.wheelsMETAL;
            LIST2.wheelsR = this.wheelsR;
            LIST2.wheelsG = this.wheelsG;
            LIST2.wheelsB = this.wheelsB;
            /// EZ GAZI PRODUKTIONZ
            LIST2.hood = this.hood;
            LIST2.stockbody = this.stockbody;
            LIST2.widebody = this.widebody;
            LIST2.spoiler = this.spoiler;
            LIST2.brakesLVL1 = this.brakesLVL1;
            LIST2.brakesLVL2 = this.brakesLVL2;
            LIST2.brakesLVL3 = this.brakesLVL3;
            LIST2.exhaustLVL1 = this.exhaustLVL1;
            LIST2.exhaustLVL2 = this.exhaustLVL2;
            LIST2.exhaustLVL3 = this.exhaustLVL3;
            LIST2.intakeLVL1 = this.intakeLVL1;
            LIST2.intakeLVL2 = this.intakeLVL2;
            LIST2.intakeLVL3 = this.intakeLVL3;
        }
        if (ZZZTOYOTA)
        {
            KAR1.SetActive(false);
            KAR2.SetActive(false);
            KAR3.SetActive(true);
            KAR4.SetActive(false);
            ButtonMIRA.image.color = new Color(255f, 255f, 255f);
            ButtonSAMURAI.image.color = new Color(255f, 255f, 255f);
            ButtonCAMRY.image.color = new Color(0f, 255f, 0f);
            Button180SX.image.color = new Color(255f, 255f, 255f);
            LIST3 = SPAWNER.GetChild(0).transform.GetChild(1).transform.gameObject.GetComponent<ModdingList2>();
            /// EZ GAZI PRODUKTIONZ
            LIST3.bodyMETAL = this.bodyMETAL;
            LIST3.bodyR = this.bodyR;
            LIST3.bodyG = this.bodyG;
            LIST3.bodyB = this.bodyB;
            /// EZ GAZI PRODUKTIONZ
            LIST3.engineMETAL = this.engineMETAL;
            LIST3.engineR = this.engineR;
            LIST3.engineG = this.engineG;
            LIST3.engineB = this.engineB;
            /// EZ GAZI PRODUKTIONZ
            LIST3.wheelsMETAL = this.wheelsMETAL;
            LIST3.wheelsR = this.wheelsR;
            LIST3.wheelsG = this.wheelsG;
            LIST3.wheelsB = this.wheelsB;
            /// EZ GAZI PRODUKTIONZ
            LIST3.hood = this.hood;
            LIST3.stockbody = this.stockbody;
            LIST3.widebody = this.widebody;
            LIST3.spoiler = this.spoiler;
            LIST3.brakesLVL1 = this.brakesLVL1;
            LIST3.brakesLVL2 = this.brakesLVL2;
            LIST3.brakesLVL3 = this.brakesLVL3;
            LIST3.exhaustLVL1 = this.exhaustLVL1;
            LIST3.exhaustLVL2 = this.exhaustLVL2;
            LIST3.exhaustLVL3 = this.exhaustLVL3;
            LIST3.intakeLVL1 = this.intakeLVL1;
            LIST3.intakeLVL2 = this.intakeLVL2;
            LIST3.intakeLVL3 = this.intakeLVL3;
        }
        if (ZZZNISSAN)
        {
            KAR1.SetActive(false);
            KAR2.SetActive(false);
            KAR3.SetActive(false);
            KAR4.SetActive(true);
            ButtonMIRA.image.color = new Color(255f, 255f, 255f);
            ButtonSAMURAI.image.color = new Color(255f, 255f, 255f);
            ButtonCAMRY.image.color = new Color(255f, 255f, 255f);
            Button180SX.image.color = new Color(0f, 255f, 0f);
            LIST4 = SPAWNER.GetChild(0).transform.GetChild(1).transform.gameObject.GetComponent<ModdingList3>();
            /// EZ GAZI PRODUKTIONZ
            LIST4.bodyMETAL = this.bodyMETAL;
            LIST4.bodyR = this.bodyR;
            LIST4.bodyG = this.bodyG;
            LIST4.bodyB = this.bodyB;
            /// EZ GAZI PRODUKTIONZ
            LIST4.engineMETAL = this.engineMETAL;
            LIST4.engineR = this.engineR;
            LIST4.engineG = this.engineG;
            LIST4.engineB = this.engineB;
            /// EZ GAZI PRODUKTIONZ
            LIST4.wheelsMETAL = this.wheelsMETAL;
            LIST4.wheelsR = this.wheelsR;
            LIST4.wheelsG = this.wheelsG;
            LIST4.wheelsB = this.wheelsB;
            /// EZ GAZI PRODUKTIONZ
            LIST4.hood = this.hood;
            LIST4.stockbody = this.stockbody;
            LIST4.widebody = this.widebody;
            LIST4.spoiler = this.spoiler;
            LIST4.brakesLVL1 = this.brakesLVL1;
            LIST4.brakesLVL2 = this.brakesLVL2;
            LIST4.brakesLVL3 = this.brakesLVL3;
            LIST4.exhaustLVL1 = this.exhaustLVL1;
            LIST4.exhaustLVL2 = this.exhaustLVL2;
            LIST4.exhaustLVL3 = this.exhaustLVL3;
            LIST4.intakeLVL1 = this.intakeLVL1;
            LIST4.intakeLVL2 = this.intakeLVL2;
            LIST4.intakeLVL3 = this.intakeLVL3;
        }
        if (stockbody)
        {
            ButtonSTOCKBODY.image.color = new Color(0f, 255f, 0f);
            ButtonWIDEBODY.image.color = new Color(255f, 255f, 255f);
            stockbody = true;
            widebody = false;
        }
        if (widebody)
        {
            ButtonSTOCKBODY.image.color = new Color(255f, 255f, 255f);
            ButtonWIDEBODY.image.color = new Color(0f, 255f, 0f);
            stockbody = false;
            widebody = true;
        }
        if (WASHOOD)
        {
            if (ISHOOD)
            {
                hood = true;
            }
            else
            {
                hood = false;
            }
            if (hood)
            {
                ISHOOD = true;
            }
            else
            {
                ISHOOD = false;
            }
        }
        else
        {
            hood = false;
        }
        if (hood)
        {
            ButtonHOOD.image.color = new Color(0f, 255f, 0f);
            ButtonHOODOFF.image.color = new Color(255f, 255f, 255f);
            hood = true;
        }
        if (hood == false)
        {
            ButtonHOOD.image.color = new Color(255f, 255f, 255f);
            ButtonHOODOFF.image.color = new Color(0f, 255f, 0f);
            hood = false;
        }
        if (spoiler == false)
        {
            ButtonSPOILER.image.color = new Color(255f, 255f, 255f);
            ButtonSPOILEROFF.image.color = new Color(0f, 255f, 0f);
            spoiler = false;
        }
        if (spoiler)
        {
            ButtonSPOILER.image.color = new Color(0f, 255f, 0f);
            ButtonSPOILEROFF.image.color = new Color(255f, 255f, 255f);
            spoiler = true;
        }
        if (exhaustLVL1)
        {
            ButtonEXHAUSTLVL1.image.color = new Color(0f, 255f, 0f);
            ButtonEXHAUSTLVL2.image.color = new Color(255f, 255f, 255f);
            ButtonEXHAUSTLVL3.image.color = new Color(255f, 255f, 255f);
            exhaustLVL1 = true;
            exhaustLVL2 = false;
            exhaustLVL3 = false;
        }
        if (exhaustLVL2)
        {
            ButtonEXHAUSTLVL1.image.color = new Color(255f, 255f, 255f);
            ButtonEXHAUSTLVL2.image.color = new Color(0f, 255f, 0f);
            ButtonEXHAUSTLVL3.image.color = new Color(255f, 255f, 255f);
            exhaustLVL1 = false;
            exhaustLVL2 = true;
            exhaustLVL3 = false;
        }
        if (exhaustLVL3)
        {
            ButtonEXHAUSTLVL1.image.color = new Color(255f, 255f, 255f);
            ButtonEXHAUSTLVL2.image.color = new Color(255f, 255f, 255f);
            ButtonEXHAUSTLVL3.image.color = new Color(0f, 255f, 0f);
            exhaustLVL1 = false;
            exhaustLVL2 = false;
            exhaustLVL3 = true;
        }
        if (intakeLVL1)
        {
            ButtonINTAKELVL1.image.color = new Color(0f, 255f, 0f);
            ButtonINTAKELVL2.image.color = new Color(255f, 255f, 255f);
            ButtonINTAKELVL3.image.color = new Color(255f, 255f, 255f);
            intakeLVL1 = true;
            intakeLVL2 = false;
            intakeLVL3 = false;
        }
        if (intakeLVL2)
        {
            ButtonINTAKELVL1.image.color = new Color(255f, 255f, 255f);
            ButtonINTAKELVL2.image.color = new Color(0f, 255f, 0f);
            ButtonINTAKELVL3.image.color = new Color(255f, 255f, 255f);
            intakeLVL1 = false;
            intakeLVL2 = true;
            intakeLVL3 = false;
        }
        if (intakeLVL3)
        {
            ButtonINTAKELVL1.image.color = new Color(255f, 255f, 255f);
            ButtonINTAKELVL2.image.color = new Color(255f, 255f, 255f);
            ButtonINTAKELVL3.image.color = new Color(0f, 255f, 0f);
            intakeLVL1 = false;
            intakeLVL2 = false;
            intakeLVL3 = true;
        }
        if (brakesLVL1)
        {
            ButtonBRAKESLVL1.image.color = new Color(0f, 255f, 0f);
            ButtonBRAKESLVL2.image.color = new Color(255f, 255f, 255f);
            ButtonBRAKESLVL3.image.color = new Color(255f, 255f, 255f);
            brakesLVL1 = true;
            brakesLVL2 = false;
            brakesLVL3 = false;
        }
        if (brakesLVL2)
        {
            ButtonBRAKESLVL1.image.color = new Color(255f, 255f, 255f);
            ButtonBRAKESLVL2.image.color = new Color(0f, 255f, 0f);
            ButtonBRAKESLVL3.image.color = new Color(255f, 255f, 255f);
            brakesLVL1 = false;
            brakesLVL2 = true;
            brakesLVL3 = false;
        }
        if (brakesLVL3)
        {
            ButtonBRAKESLVL1.image.color = new Color(255f, 255f, 255f);
            ButtonBRAKESLVL2.image.color = new Color(255f, 255f, 255f);
            ButtonBRAKESLVL3.image.color = new Color(0f, 255f, 0f);
            brakesLVL1 = false;
            brakesLVL2 = false;
            brakesLVL3 = true;
        }
        if (MAPSELECT == 1)
        {
            new WaitForSeconds(0.1f);
            SMP1();
        }
        if (MAPSELECT == 2)
        {
            new WaitForSeconds(0.1f);
            SMP2();
        }
        if (MAPSELECT == 3)
        {
            new WaitForSeconds(0.1f);
            SMP3();
        }
    }
    public void RESETCAM()
    {
        ROTATOR1.ResetRotation();
        ROTATOR2.ResetRotation();
    }
    public void BODYCAM()
    {
        ROTATOR1.gameObject.SetActive(true);
        ROTATOR2.gameObject.SetActive(false);
    }
    public void ENGINECAM()
    {
        ROTATOR1.gameObject.SetActive(false);
        ROTATOR2.gameObject.SetActive(true);
    }
    public void RESETCARS()
    {
        if (ZZZDAIHATSU)
        {
            MIRA();
        }
        if (ZZZSUZUKI)
        {
            SAMURAI();
        }
        if (ZZZTOYOTA)
        {
            CAMRY();
        }
        if (ZZZNISSAN)
        {
            N180SX();
        }
    }
    public void MIRA()
    {
        ROTATOR1.ResetRotation();
        Destroy(SPAWNER.GetChild(0).gameObject);
        Instantiate(DAIHATSU, SPAWNER);
        ZZZDAIHATSU = true;
        ZZZSUZUKI = false;
        ZZZTOYOTA = false;
        ZZZNISSAN = false;
    }
    public void SAMURAI()
    {
        ROTATOR1.ResetRotation();
        Destroy(SPAWNER.GetChild(0).gameObject);
        Instantiate(SUZUKI, SPAWNER);
        ZZZDAIHATSU = false;
        ZZZSUZUKI = true;
        ZZZTOYOTA = false;
        ZZZNISSAN = false;
    }
    public void CAMRY()
    {
        ROTATOR1.ResetRotation();
        Destroy(SPAWNER.GetChild(0).gameObject);
        Instantiate(TOYOTA, SPAWNER);
        ZZZDAIHATSU = false;
        ZZZSUZUKI = false;
        ZZZTOYOTA = true;
        ZZZNISSAN = false;
    }
    public void N180SX()
    {
        ROTATOR1.ResetRotation();
        Destroy(SPAWNER.GetChild(0).gameObject);
        Instantiate(NISSAN, SPAWNER);
        ZZZDAIHATSU = false;
        ZZZSUZUKI = false;
        ZZZTOYOTA = false;
        ZZZNISSAN = true;
    }
    public void STOCKBODY()
    {
        ROTATOR1.ResetRotation();
        stockbody = true;
        widebody = false;
    }
    public void WIDEBODY()
    {
        ROTATOR1.ResetRotation();
        stockbody = false;
        widebody = true;
    }
    public void HOOD()
    {
        ROTATOR1.ResetRotation();
        ISHOOD = true;
    }
    public void HOODOFF()
    {
        ROTATOR1.ResetRotation();
        ISHOOD = false;
    }
    public void SPOILEROFF()
    {
        ROTATOR1.ResetRotation();
        spoiler = false;
    }
    public void SPOILER()
    {
        ROTATOR1.ResetRotation();
        spoiler = true;
    }
    public void EXHAUSTLVL1()
    {
        RESETCARS();
        RESETCAM();
        exhaustLVL1 = true;
        exhaustLVL2 = false;
        exhaustLVL3 = false;
    }
    public void EXHAUSTLVL2()
    {
        RESETCARS();
        RESETCAM();
        exhaustLVL1 = false;
        exhaustLVL2 = true;
        exhaustLVL3 = false;
    }
    public void EXHAUSTLVL3()
    {
        RESETCARS();
        RESETCAM();
        exhaustLVL1 = false;
        exhaustLVL2 = false;
        exhaustLVL3 = true;
    }
    public void INTAKELVL1()
    {
        RESETCARS();
        RESETCAM();
        intakeLVL1 = true;
        intakeLVL2 = false;
        intakeLVL3 = false;
    }
    public void INTAKELVL2()
    {
        RESETCARS();
        RESETCAM();
        intakeLVL1 = false;
        intakeLVL2 = true;
        intakeLVL3 = false;
    }
    public void INTAKELVL3()
    {
        RESETCARS();
        RESETCAM();
        intakeLVL1 = false;
        intakeLVL2 = false;
        intakeLVL3 = true;
    }
    public void BRAKESLVL1()
    {
        RESETCARS();
        RESETCAM();
        brakesLVL1 = true;
        brakesLVL2 = false;
        brakesLVL3 = false;
    }
    public void BRAKESLVL2()
    {
        RESETCARS();
        RESETCAM();
        brakesLVL1 = false;
        brakesLVL2 = true;
        brakesLVL3 = false;
    }
    public void BRAKESLVL3()
    {
        RESETCARS();
        RESETCAM();
        brakesLVL1 = false;
        brakesLVL2 = false;
        brakesLVL3 = true;
    }
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    public void PURCHASE_DAIHATSU()
    {
        if (coins >= 4000f)
        {
            coins -= 4000f;
            boughtDAIHATSU = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_SUZUKI()
    {
        if (coins >= 8000f)
        {
            coins -= 8000f;
            boughtSUZUKI = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_TOYOTA()
    {
        if (coins >= 12000f)
        {
            coins -= 12000f;
            boughtTOYOTA = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_NISSAN()
    {
        if (coins >= 16000f)
        {
            coins -= 16000f;
            boughtNISSAN = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_SPOILER()
    {
        if (coins >= 5000f)
        {
            coins -= 5000f;
            boughtSPOILER = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_WIDEBODY()
    {
        if (coins >= 5000f)
        {
            coins -= 5000f;
            boughtWIDEBODY = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_E2()
    {
        if (coins >= 3000f)
        {
            coins -= 3000f;
            boughtEXHAUSTLVL2 = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_E3()
    {
        if (coins >= 6000f)
        {
            coins -= 6000f;
            boughtEXHAUSTLVL3 = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_I2()
    {
        if (coins >= 3000f)
        {
            coins -= 3000f;
            boughtINTAKELVL2 = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_I3()
    {
        if (coins >= 6000f)
        {
            coins -= 6000f;
            boughtINTAKELVL3 = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_B2()
    {
        if (coins >= 3000f)
        {
            coins -= 3000f;
            boughtBRAKESLVL2 = true;
            BUYSOUND.Play();
        }
    }
    public void PURCHASE_B3()
    {
        if (coins >= 6000f)
        {
            coins -= 6000f;
            boughtBRAKESLVL3 = true;
            BUYSOUND.Play();
        }
    }
    public void STARTMAP1()
    {
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        MAPSELECT = 1;
    }
    public void SMP1()
    {
        SaveSystem.SavePlayer(this);
        SceneManager.LoadScene("HAKUZAKI");
    }
    public void STARTMAP2()
    {
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        MAPSELECT = 2;
    }
    public void SMP2()
    {
        SaveSystem.SavePlayer(this);
        SceneManager.LoadScene("DRAGIV");
    }
    public void STARTMAP3()
    {
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        LOADING.SetActive(true);
        MAPSELECT = 3;
    }
    public void SMP3()
    {
        SaveSystem.SavePlayer(this);
        SceneManager.LoadScene("DRAG");
    }
    public void SAVEXIT()
    {
        SaveSystem.SavePlayer(this);
        SceneManager.LoadScene("MENU");
    }
}
