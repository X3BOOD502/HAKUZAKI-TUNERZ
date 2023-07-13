using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModdingList : MonoBehaviour
{
    private float RNG = 1;
    public bool RE = true;
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
    public TMP_Text Coins;
    public GameObject Hood;
    public GameObject Stockbody;
    public GameObject Widebody;
    public GameObject Spoiler;
    /// EZ GAZI PRODUKTIONZ
    public GameObject Brake1LVL1;
    public GameObject Brake2LVL1;
    public GameObject Brake3LVL1;
    public GameObject Brake4LVL1;
    /// EZ GAZI PRODUKTIONZ
    public GameObject Brake1LVL2;
    public GameObject Brake2LVL2;
    public GameObject Brake3LVL2;
    public GameObject Brake4LVL2;
    /// EZ GAZI PRODUKTIONZ
    public GameObject Brake1LVL3;
    public GameObject Brake2LVL3;
    public GameObject Brake3LVL3;
    public GameObject Brake4LVL3;
    /// EZ GAZI PRODUKTIONZ
    public GameObject ExhaustLVL1;
    public GameObject ExhaustLVL2;
    public GameObject ExhaustLVL3;
    public GameObject IntakeLVL1;
    public GameObject IntakeLVL2;
    public GameObject IntakeLVL3;
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    /// EZ GAZI PRODUKTIONZ
    public MeshRenderer ZZZWheel1;
    public MeshRenderer ZZZWheel2;
    public MeshRenderer ZZZWheel3;
    public MeshRenderer ZZZWheel4;
    public MeshRenderer ZZZLDoor;
    public MeshRenderer ZZZRDoor;
    public MeshRenderer ZZZHood;
    public MeshRenderer ZZZStockbody;
    public MeshRenderer ZZZWidebody;
    public MeshRenderer ZZZSpoiler;
    public MeshRenderer ZZZBrake1LVL1;
    public MeshRenderer ZZZBrake2LVL1;
    public MeshRenderer ZZZBrake3LVL1;
    public MeshRenderer ZZZBrake4LVL1;
    public MeshRenderer ZZZBrake1LVL2;
    public MeshRenderer ZZZBrake2LVL2;
    public MeshRenderer ZZZBrake3LVL2;
    public MeshRenderer ZZZBrake4LVL2;
    public MeshRenderer ZZZBrake1LVL3;
    public MeshRenderer ZZZBrake2LVL3;
    public MeshRenderer ZZZBrake3LVL3;
    public MeshRenderer ZZZBrake4LVL3;
    public MeshRenderer ZZZBlock;
    public MeshRenderer ZZZExhaustLVL1;
    public MeshRenderer ZZZExhaustLVL2;
    public MeshRenderer ZZZExhaustLVL3;
    public MeshRenderer ZZZIntakeLVL1;
    public MeshRenderer ZZZIntakeLVL2;
    public MeshRenderer ZZZIntakeLVL3;
    void Start()
    {
        if (RE)
        {
            PlayerData data = SaveSystem.LoadPlayer();
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
        }
        else
        {
            bodyMETAL = Random.Range(0, 256);
            bodyR = Random.Range(0, 256);
            bodyG = Random.Range(0, 256);
            bodyB = Random.Range(0, 256);
            engineMETAL = Random.Range(1, 256);
            engineR = Random.Range(0, 256);
            engineG = Random.Range(0, 256);
            engineB = Random.Range(0, 256);
            wheelsMETAL = Random.Range(0, 256);
            wheelsR = Random.Range(0, 256);
            wheelsG = Random.Range(0, 256);
            wheelsB = Random.Range(0, 256);
            RNG = Random.Range(1, 3); if (RNG == 1) { hood = true; } if (RNG == 2) { hood = false; }
            RNG = Random.Range(1, 3); if (RNG == 1) { stockbody = true; } if (RNG == 2) { widebody = true; }
            RNG = Random.Range(1, 3); if (RNG == 1) { spoiler = true; } if (RNG == 2) { spoiler = false; }
            RNG = Random.Range(1, 4); if (RNG == 1) { brakesLVL1 = true; } if (RNG == 2) { brakesLVL2 = true; } if (RNG == 3) { brakesLVL3 = true; }
            RNG = Random.Range(1, 4); if (RNG == 1) { exhaustLVL1 = true; } if (RNG == 2) { exhaustLVL2 = true; } if (RNG == 3) { exhaustLVL3 = true; }
            RNG = Random.Range(1, 4); if (RNG == 1) { intakeLVL1 = true; } if (RNG == 2) { intakeLVL2 = true; } if (RNG == 3) { intakeLVL3 = true; }
        }
    }
    void Update()
    {
        Coins.text = coins.ToString("000000") + "";
        if (hood) { Hood.SetActive(true); } else { Hood.SetActive(false); }
        if (stockbody) { Stockbody.SetActive(true); } else { Stockbody.SetActive(false); }
        if (widebody) { Widebody.SetActive(true); } else { Widebody.SetActive(false); }
        if (spoiler) { Spoiler.SetActive(true); } else { Spoiler.SetActive(false); }
        /// EZ GAZI PRODUKTIONZ
        /// EZ GAZI PRODUKTIONZ
        /// EZ GAZI PRODUKTIONZ
        if (brakesLVL1) { Brake1LVL1.SetActive(true); } else { Brake1LVL1.SetActive(false); }
        if (brakesLVL1) { Brake2LVL1.SetActive(true); } else { Brake2LVL1.SetActive(false); }
        if (brakesLVL1) { Brake3LVL1.SetActive(true); } else { Brake3LVL1.SetActive(false); }
        if (brakesLVL1) { Brake4LVL1.SetActive(true); } else { Brake4LVL1.SetActive(false); }
        /// EZ GAZI PRODUKTIONZ
        if (brakesLVL2) { Brake1LVL2.SetActive(true); } else { Brake1LVL2.SetActive(false); }
        if (brakesLVL2) { Brake2LVL2.SetActive(true); } else { Brake2LVL2.SetActive(false); }
        if (brakesLVL2) { Brake3LVL2.SetActive(true); } else { Brake3LVL2.SetActive(false); }
        if (brakesLVL2) { Brake4LVL2.SetActive(true); } else { Brake4LVL2.SetActive(false); }
        /// EZ GAZI PRODUKTIONZ
        if (brakesLVL3) { Brake1LVL3.SetActive(true); } else { Brake1LVL3.SetActive(false); }
        if (brakesLVL3) { Brake2LVL3.SetActive(true); } else { Brake2LVL3.SetActive(false); }
        if (brakesLVL3) { Brake3LVL3.SetActive(true); } else { Brake3LVL3.SetActive(false); }
        if (brakesLVL3) { Brake4LVL3.SetActive(true); } else { Brake4LVL3.SetActive(false); }
        /// EZ GAZI PRODUKTIONZ
        /// EZ GAZI PRODUKTIONZ
        /// EZ GAZI PRODUKTIONZ
        if (exhaustLVL1) { ExhaustLVL1.SetActive(true); } else { ExhaustLVL1.SetActive(false); }
        if (exhaustLVL2) { ExhaustLVL2.SetActive(true); } else { ExhaustLVL2.SetActive(false); }
        if (exhaustLVL3) { ExhaustLVL3.SetActive(true); } else { ExhaustLVL3.SetActive(false); }
        if (intakeLVL1) { IntakeLVL1.SetActive(true); } else { IntakeLVL1.SetActive(false); }
        if (intakeLVL2) { IntakeLVL2.SetActive(true); } else { IntakeLVL2.SetActive(false); }
        if (intakeLVL3) { IntakeLVL3.SetActive(true); } else { IntakeLVL3.SetActive(false); }
        /// EZ GAZI PRODUKTIONZ
        /// EZ GAZI PRODUKTIONZ
        /// EZ GAZI PRODUKTIONZ
        ZZZWheel1.materials[0].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZWheel2.materials[0].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZWheel3.materials[0].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZWheel4.materials[0].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZLDoor.materials[0].color = new Color(bodyR / 255f, bodyG / 255f, bodyB / 255f);
        ZZZRDoor.materials[0].color = new Color(bodyR / 255f, bodyG / 255f, bodyB / 255f);
        ZZZHood.materials[0].color = new Color(bodyR / 255f, bodyG / 255f, bodyB / 255f);
        ZZZStockbody.materials[1].color = new Color(bodyR / 255f, bodyG / 255f, bodyB / 255f);
        ZZZWidebody.materials[1].color = new Color(bodyR / 255f, bodyG / 255f, bodyB / 255f);
        ZZZSpoiler.materials[0].color = new Color(bodyR / 255f, bodyG / 255f, bodyB / 255f);
        ZZZBrake1LVL1.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake2LVL1.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake3LVL1.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake4LVL1.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake1LVL2.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake2LVL2.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake3LVL2.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake4LVL2.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake1LVL3.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake2LVL3.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake3LVL3.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBrake4LVL3.materials[1].color = new Color(wheelsR / 255f, wheelsG / 255f, wheelsB / 255f);
        ZZZBlock.materials[0].color = new Color(engineR / 255f, engineG / 255f, engineB / 255f);
        ZZZBlock.materials[2].color = new Color(engineR / 255f, engineG / 255f, engineB / 255f);
        ZZZExhaustLVL3.materials[1].color = new Color(engineR / 255f, engineG / 255f, engineB / 255f);
        ZZZIntakeLVL1.materials[1].color = new Color(engineR / 255f, engineG / 255f, engineB / 255f);
        ZZZIntakeLVL2.materials[2].color = new Color(engineR / 255f, engineG / 255f, engineB / 255f);
        ZZZIntakeLVL3.materials[2].color = new Color(engineR / 255f, engineG / 255f, engineB / 255f);
        /// EZ GAZI PRODUKTIONZ
        /// EZ GAZI PRODUKTIONZ
        /// EZ GAZI PRODUKTIONZ
        ZZZWheel1.materials[0].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZWheel2.materials[0].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZWheel3.materials[0].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZWheel4.materials[0].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZLDoor.materials[0].SetFloat("_Metallic", bodyMETAL / 255f);
        ZZZRDoor.materials[0].SetFloat("_Metallic", bodyMETAL / 255f);
        ZZZHood.materials[0].SetFloat("_Metallic", bodyMETAL / 255f);
        ZZZStockbody.materials[1].SetFloat("_Metallic", bodyMETAL / 255f);
        ZZZWidebody.materials[1].SetFloat("_Metallic", bodyMETAL / 255f);
        ZZZSpoiler.materials[0].SetFloat("_Metallic", bodyMETAL / 255f);
        ZZZBrake1LVL1.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake2LVL1.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake3LVL1.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake4LVL1.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake1LVL2.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake2LVL2.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake3LVL2.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake4LVL2.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake1LVL3.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake2LVL3.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake3LVL3.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBrake4LVL3.materials[1].SetFloat("_Metallic", wheelsMETAL / 255f);
        ZZZBlock.materials[0].SetFloat("_Metallic", engineMETAL / 255f);
        ZZZIntakeLVL3.materials[2].SetFloat("_Metallic", engineMETAL / 255f);
    }
}