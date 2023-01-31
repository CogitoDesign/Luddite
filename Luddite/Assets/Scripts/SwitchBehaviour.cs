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

    public GameObject[] crosses;

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

    public GameObject[] switchDEButtons;
   


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

    public GameObject doubleMultitoolButton;


    //turns on and off switch and gets rid of active die

    public void SwitchOneIsClicked()
    {

        if (switchOneIsOn == false)
        {
            switchOneIsOn = true;
            
            switchOneCounter += 1;

            if (switchOneCounter == 1)
            {
                crosses[0].SetActive(true);
            }
           
            else if (switchOneCounter == 3)
            {
                crosses[2].SetActive(true);
            }

            if (switchOneCounter == 3)
            {
                switchOneIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchOneIsOn == true)
        {
            switchOneIsOn = false;
            switchOneCounter += 1;

            if (switchOneCounter == 2)
            {
                crosses[1].SetActive(true);
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

            if (switchTwoCounter == 1)
            {
                crosses[3].SetActive(true);
            }

            else if (switchTwoCounter == 3)
            {
                crosses[5].SetActive(true);
            }

            if (switchTwoCounter == 3)
            {
                switchTwoIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchTwoIsOn == true)
        {
            switchTwoIsOn = false;
            switchTwoCounter += 1;

            if (switchTwoCounter == 2)
            {
                crosses[4].SetActive(true);
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

            if (switchThreeCounter == 1)
            {
                crosses[6].SetActive(true);
            }

            else if (switchThreeCounter == 3)
            {
                crosses[8].SetActive(true);
            }

            if (switchThreeCounter == 3)
            {
                switchThreeIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchThreeIsOn == true)
        {
            switchThreeIsOn = false;
            switchThreeCounter += 1;

            if (switchThreeCounter == 2)
            {
                crosses[7].SetActive(true);
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

            if (switchFourCounter == 1)
            {
                crosses[9].SetActive(true);
            }

            else if (switchFourCounter == 3)
            {
                crosses[11].SetActive(true);
            }

            if (switchFourCounter == 3)
            {
                switchFourIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchFourIsOn == true)
        {
            switchFourIsOn = false;
            switchFourCounter += 1;

            if (switchFourCounter == 2)
            {
                crosses[10].SetActive(true);
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

            if (switchFiveCounter == 1)
            {
                crosses[12].SetActive(true);
            }

            else if (switchFiveCounter == 3)
            {
                crosses[14].SetActive(true);
                gameManager.damageNumber += 2;
            }

            if (switchFiveCounter == 3)
            {
                switchFiveIsDone = true;
            }
        }
        else if (switchFiveIsOn == true)
        {
            switchFiveIsOn = false;
            switchFiveCounter += 1;

            if (switchFiveCounter == 2)
            {
                crosses[13].SetActive(true);
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

            if (switchSixCounter == 1)
            {
                crosses[15].SetActive(true);
            }

            else if (switchSixCounter == 3)
            {
                crosses[17].SetActive(true);
            }

            if (switchSixCounter == 3)
            {
                switchSixIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchSixIsOn == true)
        {
            switchSixIsOn = false;
            switchSixCounter += 1;

            if (switchSixCounter == 2)
            {
                crosses[16].SetActive(true);
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

    public void DoubleMultitoolIsClicked()
    {
        switchDEButtons[0].SetActive(true);
        switchDEButtons[1].SetActive(true);
        switchDEButtons[2].SetActive(true);
        switchDEButtons[3].SetActive(true);
        switchDEButtons[4].SetActive(true);
        switchDEButtons[5].SetActive(true);

        gameManager.multitoolNumber -= 2;
    }

    public void SwitchOneDEIsClicked()
    {

        if (switchOneIsOn == false)
        {
            switchOneIsOn = true;

            switchOneCounter += 1;

            if (switchOneCounter == 1)
            {
                crosses[0].SetActive(true);
            }

            else if (switchOneCounter == 3)
            {
                crosses[2].SetActive(true);
            }

            if (switchOneCounter == 3)
            {
                switchOneIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchOneIsOn == true)
        {
            switchOneIsOn = false;
            switchOneCounter += 1;

            if (switchOneCounter == 2)
            {
                crosses[1].SetActive(true);
            }
        }

        switchDEButtons[0].SetActive(false);
        switchDEButtons[1].SetActive(false);
        switchDEButtons[2].SetActive(false);
        switchDEButtons[3].SetActive(false);
        switchDEButtons[4].SetActive(false);
        switchDEButtons[5].SetActive(false);

    }

    public void SwitchTwoDEIsClicked()
    {

        if (switchTwoIsOn == false)
        {
            switchTwoIsOn = true;

            switchTwoCounter += 1;

            if (switchTwoCounter == 1)
            {
                crosses[3].SetActive(true);
            }

            else if (switchTwoCounter == 3)
            {
                crosses[5].SetActive(true);
            }

            if (switchTwoCounter == 3)
            {
                switchTwoIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchTwoIsOn == true)
        {
            switchTwoIsOn = false;
            switchTwoCounter += 1;

            if (switchTwoCounter == 2)
            {
                crosses[4].SetActive(true);
            }
        }

        switchDEButtons[0].SetActive(false);
        switchDEButtons[1].SetActive(false);
        switchDEButtons[2].SetActive(false);
        switchDEButtons[3].SetActive(false);
        switchDEButtons[4].SetActive(false);
        switchDEButtons[5].SetActive(false);
    }

    public void SwitchThreeDEIsClicked()
    {

        if (switchThreeIsOn == false)
        {
            switchThreeIsOn = true;

            switchThreeCounter += 1;

            if (switchThreeCounter == 1)
            {
                crosses[6].SetActive(true);
            }

            else if (switchThreeCounter == 3)
            {
                crosses[8].SetActive(true);
            }

            if (switchThreeCounter == 3)
            {
                switchThreeIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchThreeIsOn == true)
        {
            switchThreeIsOn = false;
            switchThreeCounter += 1;

            if (switchThreeCounter == 2)
            {
                crosses[7].SetActive(true);
            }
        }

        switchDEButtons[0].SetActive(false);
        switchDEButtons[1].SetActive(false);
        switchDEButtons[2].SetActive(false);
        switchDEButtons[3].SetActive(false);
        switchDEButtons[4].SetActive(false);
        switchDEButtons[5].SetActive(false);

    }

    public void SwitchFourDEIsClicked()
    {

        if (switchFourIsOn == false)
        {
            switchFourIsOn = true;

            switchFourCounter += 1;

            if (switchFourCounter == 1)
            {
                crosses[9].SetActive(true);
            }

            else if (switchFourCounter == 3)
            {
                crosses[11].SetActive(true);
            }

            if (switchFourCounter == 3)
            {
                switchFourIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchFourIsOn == true)
        {
            switchFourIsOn = false;
            switchFourCounter += 1;

            if (switchFourCounter == 2)
            {
                crosses[10].SetActive(true);
            }
        }

        switchDEButtons[0].SetActive(false);
        switchDEButtons[1].SetActive(false);
        switchDEButtons[2].SetActive(false);
        switchDEButtons[3].SetActive(false);
        switchDEButtons[4].SetActive(false);
        switchDEButtons[5].SetActive(false);

    }

    public void SwitchFiveDEIsClicked()
    {

        if (switchFiveIsOn == false)
        {
            switchFiveIsOn = true;

            switchFiveCounter += 1;

            if (switchFiveCounter == 1)
            {
                crosses[12].SetActive(true);
            }

            else if (switchFiveCounter == 3)
            {
                crosses[14].SetActive(true);
                gameManager.damageNumber += 2;
            }

            if (switchFiveCounter == 3)
            {
                switchFiveIsDone = true;
            }
        }
        else if (switchFiveIsOn == true)
        {
            switchFiveIsOn = false;
            switchFiveCounter += 1;

            if (switchFiveCounter == 2)
            {
                crosses[13].SetActive(true);
            }
        }

        switchDEButtons[0].SetActive(false);
        switchDEButtons[1].SetActive(false);
        switchDEButtons[2].SetActive(false);
        switchDEButtons[3].SetActive(false);
        switchDEButtons[4].SetActive(false);
        switchDEButtons[5].SetActive(false);
    }

    public void SwitchSixDEIsClicked()
    {

        if (switchSixIsOn == false)
        {
            switchSixIsOn = true;

            switchSixCounter += 1;

            if (switchSixCounter == 1)
            {
                crosses[15].SetActive(true);
            }

            else if (switchSixCounter == 3)
            {
                crosses[17].SetActive(true);
            }

            if (switchSixCounter == 3)
            {
                switchSixIsDone = true;
                gameManager.damageNumber += 2;
            }
        }
        else if (switchSixIsOn == true)
        {
            switchSixIsOn = false;
            switchSixCounter += 1;

            if (switchSixCounter == 2)
            {
                crosses[16].SetActive(true);
            }
        }

        switchDEButtons[0].SetActive(false);
        switchDEButtons[1].SetActive(false);
        switchDEButtons[2].SetActive(false);
        switchDEButtons[3].SetActive(false);
        switchDEButtons[4].SetActive(false);
        switchDEButtons[5].SetActive(false);
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

        //check if double multitool should be on

        if(gameManager.multitoolNumber >= 2)
        {
            doubleMultitoolButton.SetActive(true);
        }
        else
        {
            doubleMultitoolButton.SetActive(false);
        }

    }
}
