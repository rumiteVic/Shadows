using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UI : MonoBehaviour
{
    public bool isMainMenu;
    public int menu;

    public GameObject mainMenu;
    public GameObject hudMenu;
    public GameObject escMenu;
    public GameObject optionsMenu;
    public GameObject creditosMenu;
    public AudioSource uiSound;

    public float minPitch;
    public float maxPitch;

    public float volumeMin;
    public float volumeMax;

    // Start is called before the first frame update
    void Start()
    {
        if(isMainMenu)
        {
            menu = 0;
            mainMenu.gameObject.SetActive(true);
            escMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(false);
            hudMenu.gameObject.SetActive(false);
            creditosMenu.gameObject.SetActive(false);
        }
        else
        {
            menu = 3;
            mainMenu.gameObject.SetActive(false);
            escMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(false);
            hudMenu.gameObject.SetActive(true);
            creditosMenu.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !isMainMenu){
            menu = 1;
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene(2);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            SceneManager.LoadScene(3);
        }
        if (menu == 0)
        {
            //Menu home
            mainMenu.gameObject.SetActive(true);
            escMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(false);
            hudMenu.gameObject.SetActive(false);
            creditosMenu.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
        else if (menu == 1)
        {
            //EscMenu
            mainMenu.gameObject.SetActive(false);
            escMenu.gameObject.SetActive(true);
            optionsMenu.gameObject.SetActive(false);
            hudMenu.gameObject.SetActive(false);
            creditosMenu.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
        else if (menu == 2)
        {
            //OptionsMenu
            mainMenu.gameObject.SetActive(false);
            escMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(true);
            hudMenu.gameObject.SetActive(false);
            creditosMenu.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
        else if (menu == 3)
        {
            //HUD
            mainMenu.gameObject.SetActive(false);
            escMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(false);
            hudMenu.gameObject.SetActive(true);
            creditosMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
        else if (menu == 4)
        {
            mainMenu.gameObject.SetActive(false);
            escMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(false);
            hudMenu.gameObject.SetActive(false);
            creditosMenu.gameObject.SetActive(false);
        }
        else if(menu == 5){
            mainMenu.gameObject.SetActive(false);
            escMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(false);
            hudMenu.gameObject.SetActive(false);
            creditosMenu.gameObject.SetActive(true);
        }
        RandomPitch();
    }

    public void Iniciar()
    {
        uiSound.Play();
        SceneManager.LoadScene(1);
    }

    public void Opciones()
    {
        uiSound.Play();
        menu = 2;
    }
    public void Salir()
    {
        uiSound.Play();
        Application.Quit();
    }

    public void Return()
    {
        if(isMainMenu)
        {
            uiSound.Play();
            menu = 0;
        }
        else
        {
            uiSound.Play();
            menu = 1;
        }
    }

    public void Resume()
    {
        uiSound.Play();
        menu = 3;
    }

    public void ExitGame()
    {
        uiSound.Play();
        SceneManager.LoadScene(0);
    }
    public void Creditos(){
        uiSound.Play();
        menu = 5;
    }

    void RandomPitch(){
        uiSound.pitch = 1.0f + Random.Range(minPitch, maxPitch);
        uiSound.volume = 1.0f + Random.Range(volumeMin, volumeMax); 
    }
    public void Next(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
}
