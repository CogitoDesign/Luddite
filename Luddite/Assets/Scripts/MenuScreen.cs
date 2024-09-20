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

    public GameObject easyButton;
    public GameObject normalButton;
    public GameObject hardButton;
    public GameObject newGameButton;

    public AudioSource switchsound;


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
    }

}
