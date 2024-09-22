using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

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


    //set difficulty level and turn off start screen

    public void button_exit()
    {

        Application.Quit();

    }

    public void EasyModeIsChosen()
    {
       
        easyMode = true;
        normalMode = false;
        hardMode = false;
        SceneManager.LoadScene("Level 1 NEW");
        switchsound.Play();
        
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

        if(input == "L2E")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 2");
            codeSuccess.Play();
        }
        else if (input == "L2M")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 2");
            codeSuccess.Play();
        }
        else if (input == "L2H")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 2");
            codeSuccess.Play();
        }

        //Level 3

        if (input == "L3E")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 3");
            codeSuccess.Play();
        }
        else if (input == "L3M")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 3");
            codeSuccess.Play();
        }
        else if (input == "L3H")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 3");
            codeSuccess.Play();
        }


        //Level 4

        if (input == "L4E")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 4");
            codeSuccess.Play();
        }
        else if (input == "L4M")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 4");
            codeSuccess.Play();
        }
        else if (input == "L4H")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 4");
            codeSuccess.Play();
        }


        //Level 5

        if (input == "L5E")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 5");
            codeSuccess.Play();
        }
        else if (input == "L5M")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 5");
            codeSuccess.Play();
        }
        else if (input == "L5H")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 5");
            codeSuccess.Play();
        }

        //Level 6

        if (input == "L6E")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 6");
            codeSuccess.Play();
        }
        else if (input == "L6M")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 6");
            codeSuccess.Play();
        }
        else if (input == "L6H")
        {
            easyMode = false;
            normalMode = false;
            hardMode = true;
            SceneManager.LoadScene("Level 6");
            codeSuccess.Play();
        }


        //Level 7

        if (input == "L7E")
        {
            easyMode = true;
            normalMode = false;
            hardMode = false;
            SceneManager.LoadScene("Level 7");
            codeSuccess.Play();
        }
        else if (input == "L7M")
        {
            easyMode = false;
            normalMode = true;
            hardMode = false;
            SceneManager.LoadScene("Level 7");
            codeSuccess.Play();
        }
        else if (input == "L7H")
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
