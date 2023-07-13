using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject MAIN;
    public GameObject OPTIONS;
    public GameObject CONTROLS;
    public GameObject NERDS;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1;
        BACK();
    }
    public void BACK()
    {
        MAIN.SetActive(true);
        OPTIONS.SetActive(false);
        CONTROLS.SetActive(false);
        NERDS.SetActive(false);
    }
    public void OPTION()
    {
        MAIN.SetActive(false);
        OPTIONS.SetActive(true);
        CONTROLS.SetActive(false);
        NERDS.SetActive(false);
    }
    public void CONTROL()
    {
        MAIN.SetActive(false);
        OPTIONS.SetActive(false);
        CONTROLS.SetActive(true);
        NERDS.SetActive(false);
    }
    public void NERD()
    {
        MAIN.SetActive(false);
        OPTIONS.SetActive(false);
        CONTROLS.SetActive(false);
        NERDS.SetActive(true);
    }
    public void NewGame()
    {
        SceneManager.LoadScene("GARAGE_NEW");
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("GARAGE");
    }
    public void EXIT()
    {
        Application.Quit();
    }
}
