using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class MenuScreen : MonoBehaviour
{
    
    public static bool easyMode;
    public static bool normalMode;
    public static bool hardMode;


    private string input;

    public int codeValue;


    public GameObject easyButton;
    public GameObject normalButton;
    public GameObject hardButton;
    public GameObject newGameButton;
    public GameObject loadLevelButton;

    public GameObject codeInputScreen;

    public AudioSource switchsound;
    public AudioSource codeSuccess;
    public AudioSource error;


    public GameObject closeVideoButton1;


    //set difficulty level and turn off start screen

    public void button_exit()
    {

        Application.Quit();

    }

    public void EasyModeIsChosen()
    {
        switchsound.Play();
        easyMode = true;
        normalMode = false;
        hardMode = false;
        SceneManager.LoadScene("Level 1 NEW");
    }

    public void NormalModeIsChosen()
    {
        easyMode = false;
        normalMode = true;
        hardMode = false;
        SceneManager.LoadScene("Level 1 NEW");
        switchsound.Play();
        
    }

    public void HardModeIsChosen()
    {
        easyMode = false;
        normalMode = false;
        hardMode = true;
        SceneManager.LoadScene("Level 1 NEW");
        switchsound.Play();
       
    }

    public void NewGameIsClicked()
    {
        switchsound.Play();
        newGameButton.SetActive(false);
        easyButton.SetActive(true);
        normalButton.SetActive(true);
        hardButton.SetActive(true);
    }

    public void LoadLevelIsPicked()
    {
        switchsound.Play();
        codeInputScreen.SetActive(true);
        loadLevelButton.SetActive(false);
    }

    public void CodeIsEntered()
    {
        
    }

    public void ReadCode(string code)
    {
        input = code;


        //Level 2

        if(input == "PSYCHE" || input == "Psyche")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 2");
            codeSuccess.Play();
        }
        else if (input == "SMASH" || input == "Smash")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 2");
            codeSuccess.Play();
        }
        else if (input == "LUDDITE" || input == "Luddite")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 2");
            codeSuccess.Play();
        }

        //Level 3

        if (input == "NIVEN" || input == "Niven")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 3");
            codeSuccess.Play();
        }
        else if (input == "STEELWORKS" || input == "Steelworks")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 3");
            codeSuccess.Play();
        }
        else if (input == "DENG BOAT" || input == "Deng Boat")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 3");
            codeSuccess.Play();
        }


        //Level 4

        if (input == "DYNAMIC SYSTEMS" || input == "Dynamic Systems")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 4");
            codeSuccess.Play();
        }
        else if (input == "OUR UNIVERSE" || input == "Our Universe")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 4");
            codeSuccess.Play();
        }
        else if (input == "KREX" || input == "Krex")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 4");
            codeSuccess.Play();
        }


        //Level 5

        if (input == "DRED" || input == "Dred")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 5");
            codeSuccess.Play();
        }
        else if (input == "OUR HOME" || input == "Our Home")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 5");
            codeSuccess.Play();
        }
        else if (input == "SILVERSHINE" || input == "Silvershine")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 5");
            codeSuccess.Play();
        }

        //Level 6

        if (input == "SLEG" || input == "Sleg")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 6");
            codeSuccess.Play();
        }
        else if (input == "HENSLER" || input == "Hensler")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 6");
            codeSuccess.Play();
        }
        else if (input == "MARTYR" || input == "Martyr")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 6");
            codeSuccess.Play();
        }


        //Level 7

        if (input == "SCARLET" || input == "Scarlet")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 7");
            codeSuccess.Play();
        }
        else if (input == "RED" || input == "Red")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 7");
            codeSuccess.Play();
        }
        else if (input == "MAROON" || input == "Maroon")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 7");
            codeSuccess.Play();
        }


        else
        {
            error.Play();
        }
    }

    
}
