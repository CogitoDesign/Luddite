using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehaviour : MonoBehaviour
{

    public GameManager gameManager;

    bool switchOneisActive;
    bool switchTwoisActive;
    bool switchThreeisActive;
    bool switchFourisActive;
    bool switchFiveisActive;
    bool switchSixisActive;

    public bool switchOneIsOn;
    public bool switchTwoIsOn;
    public bool switchThreeIsOn;
    public bool switchFourIsOn;
    public bool switchFiveIsOn;
    public bool switchSixIsOn;
   

    public GameObject switchOneButton;
    public GameObject switchTwoButton;
    public GameObject switchThreeButton;
    public GameObject switchFourButton;
    public GameObject switchFiveButton;
    public GameObject switchSixButton;


    [SerializeField] int switchOneCounter = 0;
    [SerializeField] int switchTwoCounter = 0;
    [SerializeField] int switchThreeCounter = 0;
    [SerializeField] int switchFourCounter = 0;
    [SerializeField] int switchFiveCounter = 0;
    [SerializeField] int switchSixCounter = 0;



    bool switchOneIsDone = false;
    bool switchTwoIsDone = false;
    bool switchThreeIsDone = false;
    bool switchFourIsDone = false;
    bool switchFiveIsDone = false;
    bool switchSixIsDone = false;


    //turns on and off switch and gets rid of active die

    public void SwitchOneIsClicked()
    {

        if (switchOneIsOn == false)
        {
            switchOneIsOn = true;
            
            switchOneCounter += 1;

            if (switchOneCounter == 3)
            {
                switchOneIsDone = true;
            }
        }
        else if (switchOneIsOn == true)
        {
            switchOneIsOn = false;
            switchOneCounter += 1;

            if (switchOneCounter == 3)
            {
                switchOneIsDone = true;
            }
        }

        if (gameManager.dieOneIsActive == true)
        {
            gameManager.Die1Disable();
        }
        else if (gameManager.dieTwoIsActive == true)
        {
            gameManager.Die2Disable();
        }
        else if (gameManager.dieThreeIsActive == true)
        {
            gameManager.Die3Disable();
        }

    }

    public void SwitchTwoIsClicked()
    {

        if (switchTwoIsOn == false)
        {
            switchTwoIsOn = true;

            switchTwoCounter += 1;

            if (switchTwoCounter == 3)
            {
                switchTwoIsDone = true;
            }
        }
        else if (switchTwoIsOn == true)
        {
            switchTwoIsOn = false;
            switchTwoCounter += 1;

            if (switchTwoCounter == 3)
            {
                switchTwoIsDone = true;
            }
        }

        if (gameManager.dieOneIsActive == true)
        {
            gameManager.Die1Disable();
        }
        else if (gameManager.dieTwoIsActive == true)
        {
            gameManager.Die2Disable();
        }
        else if (gameManager.dieThreeIsActive == true)
        {
            gameManager.Die3Disable();
        }

    }

    public void SwitchThreeIsClicked()
    {

        if (switchThreeIsOn == false)
        {
            switchThreeIsOn = true;

            switchThreeCounter += 1;

            if (switchThreeCounter == 3)
            {
                switchThreeIsDone = true;
            }
        }
        else if (switchThreeIsOn == true)
        {
            switchThreeIsOn = false;
            switchThreeCounter += 1;

            if (switchThreeCounter == 3)
            {
                switchThreeIsDone = true;
            }
        }

        if (gameManager.dieOneIsActive == true)
        {
            gameManager.Die1Disable();
        }
        else if (gameManager.dieTwoIsActive == true)
        {
            gameManager.Die2Disable();
        }
        else if (gameManager.dieThreeIsActive == true)
        {
            gameManager.Die3Disable();
        }

    }

    public void SwitchFourIsClicked()
    {

        if (switchFourIsOn == false)
        {
            switchFourIsOn = true;

            switchFourCounter += 1;

            if (switchFourCounter == 3)
            {
                switchFourIsDone = true;
            }
        }
        else if (switchFourIsOn == true)
        {
            switchFourIsOn = false;
            switchFourCounter += 1;

            if (switchFourCounter == 3)
            {
                switchFourIsDone = true;
            }
        }

        if (gameManager.dieOneIsActive == true)
        {
            gameManager.Die1Disable();
        }
        else if (gameManager.dieTwoIsActive == true)
        {
            gameManager.Die2Disable();
        }
        else if (gameManager.dieThreeIsActive == true)
        {
            gameManager.Die3Disable();
        }

    }

    public void SwitchFiveIsClicked()
    {

        if (switchFiveIsOn == false)
        {
            switchFiveIsOn = true;

            switchFiveCounter += 1;

            if (switchFiveCounter == 3)
            {
                switchFiveIsDone = true;
            }
        }
        else if (switchFiveIsOn == true)
        {
            switchFiveIsOn = false;
            switchFiveCounter += 1;

            if (switchFiveCounter == 3)
            {
                switchFiveIsDone = true;
            }
        }

        if (gameManager.dieOneIsActive == true)
        {
            gameManager.Die1Disable();
        }
        else if (gameManager.dieTwoIsActive == true)
        {
            gameManager.Die2Disable();
        }
        else if (gameManager.dieThreeIsActive == true)
        {
            gameManager.Die3Disable();
        }

    }

    public void SwitchSixIsClicked()
    {

        if (switchSixIsOn == false)
        {
            switchSixIsOn = true;

            switchSixCounter += 1;

            if (switchSixCounter == 3)
            {
                switchSixIsDone = true;
            }
        }
        else if (switchSixIsOn == true)
        {
            switchSixIsOn = false;
            switchSixCounter += 1;

            if (switchSixCounter == 3)
            {
                switchSixIsDone = true;
            }
        }

        if (gameManager.dieOneIsActive == true)
        {
            gameManager.Die1Disable();
        }
        else if (gameManager.dieTwoIsActive == true)
        {
            gameManager.Die2Disable();
        }
        else if (gameManager.dieThreeIsActive == true)
        {
            gameManager.Die3Disable();
        }

    }

    // Update is called once per frame 
    void Update()
    {
        //turns switch on only if correspinding die is on
        if (gameManager.GetComponent<GameManager>().hasOne == true && switchOneIsDone == false)
        {
            switchOneButton.SetActive(true);
        }
        else
        {
            switchOneButton.SetActive(false);
        }

        if (gameManager.GetComponent<GameManager>().hasTwo == true && switchTwoIsDone == false)
        {
            switchTwoButton.SetActive(true);
        }
        else
        {
            switchTwoButton.SetActive(false);
        }

        if (gameManager.GetComponent<GameManager>().hasThree == true && switchThreeIsDone == false)
        {
            switchThreeButton.SetActive(true);
        }
        else
        {
            switchThreeButton.SetActive(false);
        }

        if (gameManager.GetComponent<GameManager>().hasFour == true && switchFourIsDone == false)
        {
            switchFourButton.SetActive(true);
        }
        else
        {
            switchFourButton.SetActive(false);
        }

        if (gameManager.GetComponent<GameManager>().hasFive == true && switchFiveIsDone == false)
        {
            switchFiveButton.SetActive(true);
        }
        else
        {
            switchFiveButton.SetActive(false);
        }

        if (gameManager.GetComponent<GameManager>().hasSix == true && switchSixIsDone == false)
        {
            switchSixButton.SetActive(true);
        }
        else
        {
            switchSixButton.SetActive(false);
        }

    }
}
