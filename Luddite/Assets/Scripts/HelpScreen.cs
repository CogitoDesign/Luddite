using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScreen : MonoBehaviour
{
    public GameObject diceModule;
    public GameObject resourcesHelp;
    public GameObject toolsHelp;
    public GameObject rollBonusHelp;
    public GameObject movementHelp1;
    public GameObject movementHelp2;
    public GameObject switchesHelp;
    public GameObject clockHelp;
    public GameObject hackHelp;

    public GameObject helpExitButton;

    public GameManager gameManager;

    public void OpenDiceModuleHelpScreen()
    {
        gameManager.select.Play();
        diceModule.SetActive(true);
        helpExitButton.SetActive(true);
    }

    public void OpenresourcesHelpScreen()
    {
        gameManager.select.Play();
        resourcesHelp.SetActive(true);
        helpExitButton.SetActive(true);
    }
    public void OpentoolsHelpScreen()
    {
        gameManager.select.Play();
        toolsHelp.SetActive(true);
        helpExitButton.SetActive(true);
    }
    public void OpenrollBonusHelpScreen()
    {
        gameManager.select.Play();
        rollBonusHelp.SetActive(true);
        helpExitButton.SetActive(true);
    }
    public void OpenmovementHelp1Screen()
    {
        gameManager.select.Play();
        movementHelp1.SetActive(true);
        helpExitButton.SetActive(true);
    }
    public void OpenmovementHelp2Screen()
    {
        gameManager.select.Play();
        movementHelp2.SetActive(true);
        helpExitButton.SetActive(true);
    }
    public void OpenswitchesHelpScreen()
    {
        gameManager.select.Play();
        switchesHelp.SetActive(true);
        helpExitButton.SetActive(true);
    }
    public void OpenclockHelpScreen()
    {
        gameManager.select.Play();
        clockHelp.SetActive(true);
        helpExitButton.SetActive(true);
    }
    public void OpenhackHelpScreen()
    {
        gameManager.select.Play();
        hackHelp.SetActive(true);
        helpExitButton.SetActive(true);
    }

    public void nextButtonClicked()
    {
        movementHelp1.SetActive(false);
        OpenmovementHelp2Screen();
    }

    public void backButtonClicked()
    {
        movementHelp2.SetActive(false);
        OpenrollBonusHelpScreen();
    }

    public void CloseHelpScreen()
    {
        gameManager.select.Play();
        diceModule.SetActive(false);
        resourcesHelp.SetActive(false);
        toolsHelp.SetActive(false);
        rollBonusHelp.SetActive(false);
        movementHelp1.SetActive(false);
        movementHelp2.SetActive(false);
        switchesHelp.SetActive(false);
        clockHelp.SetActive(false);
        hackHelp.SetActive(false);


        helpExitButton.SetActive(false);

    }


}
