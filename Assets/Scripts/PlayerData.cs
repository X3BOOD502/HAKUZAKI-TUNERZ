using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData
{
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
    public PlayerData (GarageList garagelist)
    {
        ZZZDAIHATSU = garagelist.ZZZDAIHATSU;
        ZZZSUZUKI = garagelist.ZZZSUZUKI;
        ZZZTOYOTA = garagelist.ZZZTOYOTA;
        ZZZNISSAN = garagelist.ZZZNISSAN;
        bodyMETAL = garagelist.bodyMETAL;
        bodyR = garagelist.bodyR;
        bodyG = garagelist.bodyG;
        bodyB = garagelist.bodyB;
        engineMETAL = garagelist.engineMETAL;
        engineR = garagelist.engineR;
        engineG = garagelist.engineG;
        engineB = garagelist.engineB;
        wheelsMETAL = garagelist.wheelsMETAL;
        wheelsR = garagelist.wheelsR;
        wheelsG = garagelist.wheelsG;
        wheelsB = garagelist.wheelsB;
        coins = garagelist.coins;
        hood = garagelist.hood;
        stockbody = garagelist.stockbody;
        widebody = garagelist.widebody;
        spoiler = garagelist.spoiler;
        brakesLVL1 = garagelist.brakesLVL1;
        brakesLVL2 = garagelist.brakesLVL2;
        brakesLVL3 = garagelist.brakesLVL3;
        exhaustLVL1 = garagelist.exhaustLVL1;
        exhaustLVL2 = garagelist.exhaustLVL2;
        exhaustLVL3 = garagelist.exhaustLVL3;
        intakeLVL1 = garagelist.intakeLVL1;
        intakeLVL2 = garagelist.intakeLVL2;
        intakeLVL3 = garagelist.intakeLVL3;
        boughtDAIHATSU = garagelist.boughtDAIHATSU;
        boughtSUZUKI = garagelist.boughtSUZUKI;
        boughtTOYOTA = garagelist.boughtTOYOTA;
        boughtNISSAN = garagelist.boughtNISSAN;
        boughtSPOILER = garagelist.boughtSPOILER;
        boughtWIDEBODY = garagelist.boughtWIDEBODY;
        boughtEXHAUSTLVL2 = garagelist.boughtEXHAUSTLVL2;
        boughtEXHAUSTLVL3 = garagelist.boughtEXHAUSTLVL3;
        boughtINTAKELVL2 = garagelist.boughtINTAKELVL2;
        boughtINTAKELVL3 = garagelist.boughtINTAKELVL3;
        boughtBRAKESLVL2 = garagelist.boughtBRAKESLVL2;
        boughtBRAKESLVL3 = garagelist.boughtBRAKESLVL3;
    }
    public PlayerData (Pauser pauser)
    {
        ZZZDAIHATSU = pauser.ZZZDAIHATSU;
        ZZZSUZUKI = pauser.ZZZSUZUKI;
        ZZZTOYOTA = pauser.ZZZTOYOTA;
        ZZZNISSAN = pauser.ZZZNISSAN;
        bodyMETAL = pauser.bodyMETAL;
        bodyR = pauser.bodyR;
        bodyG = pauser.bodyG;
        bodyB = pauser.bodyB;
        engineMETAL = pauser.engineMETAL;
        engineR = pauser.engineR;
        engineG = pauser.engineG;
        engineB = pauser.engineB;
        wheelsMETAL = pauser.wheelsMETAL;
        wheelsR = pauser.wheelsR;
        wheelsG = pauser.wheelsG;
        wheelsB = pauser.wheelsB;
        coins = pauser.coins;
        hood = pauser.hood;
        stockbody = pauser.stockbody;
        widebody = pauser.widebody;
        spoiler = pauser.spoiler;
        brakesLVL1 = pauser.brakesLVL1;
        brakesLVL2 = pauser.brakesLVL2;
        brakesLVL3 = pauser.brakesLVL3;
        exhaustLVL1 = pauser.exhaustLVL1;
        exhaustLVL2 = pauser.exhaustLVL2;
        exhaustLVL3 = pauser.exhaustLVL3;
        intakeLVL1 = pauser.intakeLVL1;
        intakeLVL2 = pauser.intakeLVL2;
        intakeLVL3 = pauser.intakeLVL3;
        boughtDAIHATSU = pauser.boughtDAIHATSU;
        boughtSUZUKI = pauser.boughtSUZUKI;
        boughtTOYOTA = pauser.boughtTOYOTA;
        boughtNISSAN = pauser.boughtNISSAN;
        boughtSPOILER = pauser.boughtSPOILER;
        boughtWIDEBODY = pauser.boughtWIDEBODY;
        boughtEXHAUSTLVL2 = pauser.boughtEXHAUSTLVL2;
        boughtEXHAUSTLVL3 = pauser.boughtEXHAUSTLVL3;
        boughtINTAKELVL2 = pauser.boughtINTAKELVL2;
        boughtINTAKELVL3 = pauser.boughtINTAKELVL3;
        boughtBRAKESLVL2 = pauser.boughtBRAKESLVL2;
        boughtBRAKESLVL3 = pauser.boughtBRAKESLVL3;
    }
}