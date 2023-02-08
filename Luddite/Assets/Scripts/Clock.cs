using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{

    public GameManager gameManager;

    public GameObject addDieButton;

    public GameObject fourBonusNumber;
    public GameObject fiveBonusNumber;
    public GameObject sixBonusNumber;

    private int fourBonusTracker;
    private int fiveBonusTracker;
    public int sixBonusTracker;

    public GameObject screensAppear;

    public int whatToAdd;

    public GameObject[] crosses;

    
    private int latestCross = 0;

    public GameObject clockScreen;

    public bool hasUsedClockThisRound;

    //the Add Die button is clicked, crosses are added and

    public void AddDieButtonIsClicked()
    {
        hasUsedClockThisRound = true;
        if(gameManager.GetComponent<GameManager>().hasOne == true)
        {
            if (latestCross <= 31)
            {
                AddCrosses();
                latestCross += 1;
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasTwo == true)
        {

            if (latestCross <= 30)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 31)
            {
                AddCrosses();
                latestCross += 1;
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasThree == true)
        {

            if (latestCross <= 29)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 30)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 31)
            {
                AddCrosses();
                latestCross += 1;
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasFour == true)
        {

            if (latestCross <= 28)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddClockBonus();
            }
            else if (latestCross <= 29)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 30)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 31)
            {
                AddCrosses();
                latestCross += 1;
            }

        }
        else if (gameManager.GetComponent<GameManager>().hasFive == true)
        {

            if (latestCross <= 27)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddClockBonus();
            }
            else if (latestCross <= 28)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 29)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 30)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 31)
            {
                AddCrosses();
                latestCross += 1;
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasSix == true)
        {
            if (latestCross <= 26)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddClockBonus();
            }
            else if (latestCross <= 27)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 28)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 29)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 30)
            {
                AddCrosses();
                latestCross += 1;
                AddCrosses();
                latestCross += 1;
            }
            else if (latestCross <= 31)
            {
                AddCrosses();
                latestCross += 1;
            }
        }

        if (gameManager.dieOneIsActive == true && gameManager.die1amount == 1)
        {
            gameManager.Die1Disable();
        }
        else if (gameManager.dieTwoIsActive == true && gameManager.die2amount == 1)
        {
            gameManager.Die2Disable();
        }
        else if (gameManager.dieThreeIsActive == true && gameManager.die3amount == 1)
        {
            gameManager.Die3Disable();
        }
        else if (gameManager.dieFourIsActive == true && gameManager.die4amount == 1)
        {
            gameManager.Die4Disable();
            gameManager.die4visible = false;
        }
        else if (gameManager.dieOneIsActive && gameManager.die1amount > 1)
        {
            gameManager.die1amount -= 1;
        }
        else if (gameManager.dieTwoIsActive && gameManager.die2amount > 1)
        {
            gameManager.die2amount -= 1;
        }
        else if (gameManager.dieThreeIsActive && gameManager.die3amount > 1)
        {
            gameManager.die3amount -= 1;
        }
        else if (gameManager.dieFourIsActive && gameManager.die4amount > 1)
        {
            gameManager.die4amount -= 1;
        }

        clockBonus();
    }

    private void clockBonus()
    {
        if (crosses[0].activeSelf == true && crosses[1].activeSelf == false)
        {
            gameManager.energyNumber += 1;
        }

        if (crosses[5].activeSelf == true && crosses[6].activeSelf == false)
        {
            gameManager.multitoolNumber += 1;
        }

        if (crosses[9].activeSelf == true && crosses[10].activeSelf == false)
        {
            gameManager.energyNumber += 1;
        }

        if (crosses[11].activeSelf == true && crosses[12].activeSelf == false)
        {
            gameManager.multitoolNumber += 1;
        }

        if (crosses[13].activeSelf == true && crosses[14].activeSelf == false)
        {
            gameManager.creditNumber += 1;
        }

        if (crosses[16].activeSelf == true && crosses[17].activeSelf == false)
        {
            gameManager.energyNumber += 1;
        }

        if (crosses[21].activeSelf == true && crosses[22].activeSelf == false)
        {
            gameManager.multitoolNumber += 1;
        }

        if (crosses[25].activeSelf == true && crosses[26].activeSelf == false)
        {
            gameManager.energyNumber += 1;
        }

        if (crosses[27].activeSelf == true && crosses[28].activeSelf == false)
        {
            gameManager.multitoolNumber += 1;
        }

        if (crosses[29].activeSelf == true && crosses[30].activeSelf == false)
        {
            gameManager.creditNumber += 1;
        }
    }

    private void AddCrosses()
    {

        if (latestCross <= 31)
        {
            crosses[latestCross].SetActive(true);
        }
    }

    private void AddClockBonus()
    {
        if (gameManager.GetComponent<GameManager>().hasSix == true)
        {
            sixBonusTracker += 1;
            sixBonusNumber.GetComponent<TextMeshProUGUI>().text = sixBonusTracker.ToString();
            gameManager.damageNumber += 6;
            
        }
        else if (gameManager.GetComponent<GameManager>().hasFive == true)
        {
            fiveBonusTracker += 1;
            fiveBonusNumber.GetComponent<TextMeshProUGUI>().text = fiveBonusTracker.ToString();
            gameManager.damageNumber += 5;

        }
        else if (gameManager.GetComponent<GameManager>().hasFour == true)
        {
            fourBonusTracker += 1;
            fourBonusNumber.GetComponent<TextMeshProUGUI>().text = fourBonusTracker.ToString();
            gameManager.damageNumber += 4;

        }
    }

    public void ResetClock()
    {
        hasUsedClockThisRound = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().hasOne == true)
        {
            addDieButton.SetActive(true);
        }
        else if (gameManager.GetComponent<GameManager>().hasTwo == true)
        {
            addDieButton.SetActive(true);
        }
        else if (gameManager.GetComponent<GameManager>().hasThree == true)
        {
            addDieButton.SetActive(true);
        }
        else if (gameManager.GetComponent<GameManager>().hasFour == true)
        {
            addDieButton.SetActive(true);
        }
        else if (gameManager.GetComponent<GameManager>().hasFive == true)
        {
            addDieButton.SetActive(true);
        }
        else if (gameManager.GetComponent<GameManager>().hasSix == true)
        {
            addDieButton.SetActive(true);
        }
        else
        {
            addDieButton.SetActive(false);
        }

        //add to clock if it is last die

        if (hasUsedClockThisRound == false)
        {

            if (gameManager.die1.activeSelf == true && (gameManager.die2.activeSelf == false && gameManager.die3.activeSelf == false))
            {
                AddLastToClock();
                gameManager.Die1Disable();
            }
            else if (gameManager.die2.activeSelf == true && (gameManager.die1.activeSelf == false && gameManager.die3.activeSelf == false))
            {
                AddLastToClock();
                gameManager.Die2Disable();
            }
            else if ((gameManager.die1.activeSelf == false && gameManager.die2.activeSelf == false) && gameManager.die3.activeSelf == true)
            {
                AddLastToClock();
                gameManager.Die3Disable();
            }
        }
        
        //check if last cliock box is done
        if (crosses[31].activeSelf == true)
        {
            //endGame method to go here
            Debug.Log("You scored" + gameManager.damageNumber + "damage");
        }

    }

    private void AddLastToClock()
    {
        
            if (clockScreen.activeSelf == false)
            {
                screensAppear.GetComponent<ScreensAppear>().ClockMenuIsOn();
                
            }
            AddUnusedDietoClock();
          
        
    }


    public void AddUnusedDietoClock()
    {
        whatToAdd = 0;

        Die1WhatToAdd();
        Die2WhatToAdd();
        Die3WhatToAdd();

        if (latestCross <= 31)
        {
            while(whatToAdd > 0)
            {
                AddCrosses();
                latestCross += 1;
                whatToAdd -= 1;
            }
        }
        clockBonus();
    }

    private void Die1WhatToAdd()
    {
        if(gameManager.die1.activeSelf == true)
        {
            if(gameManager.die1Number == 1)
            {
                whatToAdd += 1;
            }
            else if (gameManager.die1Number == 2)
            {
                whatToAdd += 2;
            }
            else if (gameManager.die1Number == 3)
            {
                whatToAdd += 3;
            }
            else if (gameManager.die1Number == 4)
            {
                whatToAdd += 4;
                if (latestCross <= 28)
                {
                    fourBonusTracker += 1;
                    fourBonusNumber.GetComponent<TextMeshProUGUI>().text = fourBonusTracker.ToString();
                    gameManager.damageNumber += 4;
                }
            }
            else if (gameManager.die1Number == 5)
            {
                whatToAdd += 5;
                if (latestCross <= 27)
                {
                    fiveBonusTracker += 1;
                    fiveBonusNumber.GetComponent<TextMeshProUGUI>().text = fiveBonusTracker.ToString();
                    gameManager.damageNumber += 5;
                }
            }
            else if (gameManager.die1Number == 6)
            {
                whatToAdd += 6;
                if (latestCross <= 26)
                {
                    sixBonusTracker += 1;
                    sixBonusNumber.GetComponent<TextMeshProUGUI>().text = sixBonusTracker.ToString();
                    gameManager.damageNumber += 6;
                }
            }
        }
        else
        {

        }
    }

    private void Die2WhatToAdd()
    {
        if (gameManager.die2.activeSelf == true)
        {
            if (gameManager.die2Number == 1)
            {
                whatToAdd += 1;
            }
            else if (gameManager.die2Number == 2)
            {
                whatToAdd += 2;
            }
            else if (gameManager.die2Number == 3)
            {
                whatToAdd += 3;
            }
            else if (gameManager.die2Number == 4)
            {
                whatToAdd += 4;
                if (latestCross <= 28)
                {
                    fourBonusTracker += 1;
                    fourBonusNumber.GetComponent<TextMeshProUGUI>().text = fourBonusTracker.ToString();
                    gameManager.damageNumber += 4;
                }
            }
            else if (gameManager.die2Number == 5)
            {
                whatToAdd += 5;
                if (latestCross <= 27)
                {
                    fiveBonusTracker += 1;
                    fiveBonusNumber.GetComponent<TextMeshProUGUI>().text = fiveBonusTracker.ToString();
                    gameManager.damageNumber += 5;
                }
            }
            else if (gameManager.die2Number == 6)
            {
                whatToAdd += 6;
                if (latestCross <= 26)
                {
                    sixBonusTracker += 1;
                    sixBonusNumber.GetComponent<TextMeshProUGUI>().text = sixBonusTracker.ToString();
                    gameManager.damageNumber += 6;
                }
            }
        }
        else
        {

        }
    }

    private void Die3WhatToAdd()
    {
        if (gameManager.die3.activeSelf == true)
        {
            if (gameManager.die3Number == 1)
            {
                whatToAdd += 1;
            }
            else if (gameManager.die3Number == 2)
            {
                whatToAdd += 2;
            }
            else if (gameManager.die3Number == 3)
            {
                whatToAdd += 3;
            }
            else if (gameManager.die3Number == 4)
            {
                whatToAdd += 4;
                if (latestCross <= 28)
                {
                    fourBonusTracker += 1;
                    fourBonusNumber.GetComponent<TextMeshProUGUI>().text = fourBonusTracker.ToString();
                    gameManager.damageNumber += 4;
                }
            }
            else if (gameManager.die3Number == 5)
            {
                whatToAdd += 5;
                if (latestCross <= 27)
                {
                    fiveBonusTracker += 1;
                    fiveBonusNumber.GetComponent<TextMeshProUGUI>().text = fiveBonusTracker.ToString();
                    gameManager.damageNumber += 5;
                }
            }
            else if (gameManager.die3Number == 6)
            {
                whatToAdd += 6;
                if (latestCross <= 26)
                {
                    sixBonusTracker += 1;
                    sixBonusNumber.GetComponent<TextMeshProUGUI>().text = sixBonusTracker.ToString();
                    gameManager.damageNumber += 6;
                }
            }
        }
        else
        {

        }
    }
}
