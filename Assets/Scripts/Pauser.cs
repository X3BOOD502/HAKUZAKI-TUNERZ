using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pauser : MonoBehaviour
{
    public bool WIN = false;
    public bool LOS = false;
    public bool INCAR = true;
    public bool DAIHATSU;
    public bool SUZUKI;
    public bool TOYOTA;
    public bool NISSAN;
    public GameObject PAUSEMENU;
    public GameObject MAIN;
    public GameObject CONTROLS;
    public GameObject NERDS;
    public bool IsPaused = false;
    public CarController CARCONZ;
    public ModdingList LST1;
    public ModdingList1 LST2;
    public ModdingList2 LST3;
    public ModdingList3 LST4;
    public GameObject UI1;
    public GameObject UI2;
    public GameObject UI3;
    public GameObject UI4;
    public GameObject UI5;
    public GameObject UI6;
    public GameObject UI7;
    public GameObject UI8;
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    public bool ZZZDAIHATSU;
    public bool ZZZSUZUKI;
    public bool ZZZTOYOTA;
    public bool ZZZNISSAN;
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
    void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        DAIHATSU = data.ZZZDAIHATSU;
        SUZUKI = data.ZZZSUZUKI;
        TOYOTA = data.ZZZTOYOTA;
        NISSAN = data.ZZZNISSAN;
        bodyMETAL = data.bodyMETAL;
        bodyR = data.bodyR;
        bodyG = data.bodyG;
        bodyB = data.bodyB;
        engineMETAL = data.engineMETAL;
        engineR = data.engineR;
        engineG = data.engineG;
        engineB = data.engineB;
        wheelsMETAL = data.wheelsMETAL;
        wheelsR = data.wheelsR;
        wheelsG = data.wheelsG;
        wheelsB = data.wheelsB;
        coins = data.coins;
        hood = data.hood;
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
        if (INCAR)
        {
            UNPAUSE();
            B_BACK();
        }
        else
        {
            if (WIN)
            {
                this.coins += 5000f;
            }
            if (LOS)
            {
                this.coins += 1000f;
            }
        }
    }
    void Update()
    {
        ZZZDAIHATSU = DAIHATSU;
        ZZZSUZUKI = SUZUKI;
        ZZZTOYOTA = TOYOTA;
        ZZZNISSAN = NISSAN;
        if (INCAR) 
        {
            if (DAIHATSU)
            {
                coins = LST1.coins;
            }
            if (SUZUKI)
            {
                coins = LST2.coins;
            }
            if (TOYOTA)
            {
                coins = LST3.coins;
            }
            if (NISSAN)
            {
                coins = LST4.coins;
            }
            /// EZ GAZI PRODUKTIONZ
            if (IsPaused)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    UNPAUSE();
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    PAUSE();
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape)) 
            {
                EXIT2GARAGE();
            }
        }
    }
    public void PAUSE()
    {
        if (CARCONZ != null)
        {
            B_BACK();
            IsPaused = true;
            PAUSEMENU.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
    public void UNPAUSE()
    {
        if (CARCONZ != null)
        {
            IsPaused = false;
            PAUSEMENU.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
        }
    }
    /// EZ GAZI PRODUKTIONZ
    public void B_BACK()
    {
        MAIN.SetActive(true);
        CONTROLS.SetActive(false);
        NERDS.SetActive(false);
    }
    public void B_CONTROLS()
    {
        MAIN.SetActive(false);
        CONTROLS.SetActive(true);
        NERDS.SetActive(false);
    }
    public void B_NERDS()
    {
        MAIN.SetActive(false);
        CONTROLS.SetActive(false);
        NERDS.SetActive(true);
    }
    public void GEARBOX(bool TOGGLE)
    {
        CARCONZ.AUTOMATIC = TOGGLE;
    }
    public void EPICGAMERUI(bool TOGGLEZ)
    {
        if (TOGGLEZ)
        {
            UI1.SetActive(false);
            UI2.SetActive(false);
            UI3.SetActive(false);
            UI4.SetActive(false);
            UI5.SetActive(false);
            UI6.SetActive(false);
            UI7.SetActive(false);
            UI8.SetActive(false);
        }
        else
        {
            UI1.SetActive(true);
            UI2.SetActive(true);
            UI3.SetActive(true);
            UI4.SetActive(true);
            UI5.SetActive(true);
            UI6.SetActive(true);
            UI7.SetActive(true);
            UI8.SetActive(true);
        }
    }
    public void EXIT2GARAGE()
    {
        Time.timeScale = 1;
        SaveSystem.SaveCoins(this);
        SceneManager.LoadScene("GARAGE");
    }
}
