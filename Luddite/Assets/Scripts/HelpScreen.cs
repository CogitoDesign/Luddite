using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScreen : MonoBehaviour
{
    public GameObject diceModule;
    public GameObject helpExitButton;
    public GameManager gameManager;

    public void OpenDiceModuleHelpScreen()
    {
        gameManager.select.Play();
        diceModule.SetActive(true);
        helpExitButton.SetActive(true);
    }

    public void CloseHelpScreen()
    {
        gameManager.select.Play();
        diceModule.SetActive(false);
        helpExitButton.SetActive(false);
    }


}
