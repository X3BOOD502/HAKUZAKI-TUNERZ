using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garage : MonoBehaviour
{
    public GarageList GARAGELIST;
    public GameObject CUSTOMIZATIONS;
    public GameObject MAPS;
    public GameObject MENU;
    public GameObject BODYS;
    public GameObject PAINTS;
    public GameObject EXHAUSTS;
    public GameObject INTAKES;
    public GameObject BRAKES;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1;
        BACK();
        CUZTOMIZE();
    }
    public void CUZTOMIZE()
    {
        CUSTOMIZATIONS.SetActive(true);
        MAPS.SetActive(false);
    }
    public void MAP()
    {
        CUSTOMIZATIONS.SetActive(false);
        MAPS.SetActive(true);
    }
    public void BACK()
    {
        GARAGELIST.WASHOOD = true;
        GARAGELIST.BODYCAM();
        GARAGELIST.RESETCAM();
        MENU.SetActive(true);
        PAINTS.SetActive(false);
        BODYS.SetActive(false);
        EXHAUSTS.SetActive(false);
        INTAKES.SetActive(false);
        BRAKES.SetActive(false);
    }
    public void PAINT()
    {
        MENU.SetActive(false);
        PAINTS.SetActive(true);
        BODYS.SetActive(false);
        EXHAUSTS.SetActive(false);
        INTAKES.SetActive(false);
        BRAKES.SetActive(false);
    }
    public void BODY()
    {
        MENU.SetActive(false);
        PAINTS.SetActive(false);
        BODYS.SetActive(true);
        EXHAUSTS.SetActive(false);
        INTAKES.SetActive(false);
        BRAKES.SetActive(false);
    }
    public void EXHAUST()
    {
        GARAGELIST.WASHOOD = false;
        GARAGELIST.ENGINECAM();
        GARAGELIST.RESETCAM();
        MENU.SetActive(false);
        PAINTS.SetActive(false);
        BODYS.SetActive(false);
        EXHAUSTS.SetActive(true);
        INTAKES.SetActive(false);
        BRAKES.SetActive(false);
    }
    public void INTAKE()
    {
        GARAGELIST.WASHOOD = false;
        GARAGELIST.ENGINECAM();
        GARAGELIST.RESETCAM();
        MENU.SetActive(false);
        PAINTS.SetActive(false);
        BODYS.SetActive(false);
        EXHAUSTS.SetActive(false);
        INTAKES.SetActive(true);
        BRAKES.SetActive(false);
    }
    public void BRAKE()
    {
        MENU.SetActive(false);
        PAINTS.SetActive(false);
        BODYS.SetActive(false);
        EXHAUSTS.SetActive(false);
        INTAKES.SetActive(false);
        BRAKES.SetActive(true);
    }
}
