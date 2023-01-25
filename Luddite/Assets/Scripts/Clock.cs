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


    public GameObject[] crosses;

    int latestCross = 0;

    //the Add Die button is clicked, crosses are added and

    public void AddDieButtonIsClicked()
    {
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

    private void AddCrosses()
    {
  
        crosses[latestCross].SetActive(true);
    }

    private void AddClockBonus()
    {
        if (gameManager.GetComponent<GameManager>().hasSix == true)
        {
            sixBonusTracker += 1;
            sixBonusNumber.GetComponent<TextMeshProUGUI>().text = sixBonusTracker.ToString();
            
        }
        else if (gameManager.GetComponent<GameManager>().hasFive == true)
        {
            fiveBonusTracker += 1;
            fiveBonusNumber.GetComponent<TextMeshProUGUI>().text = fiveBonusTracker.ToString();

        }
        else if (gameManager.GetComponent<GameManager>().hasFour == true)
        {
            fourBonusTracker += 1;
            fourBonusNumber.GetComponent<TextMeshProUGUI>().text = fourBonusTracker.ToString();

        }
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

        //check if last cliock box is done
        if (crosses[31].activeSelf == true)
        {
            //endGame method to go here
        }
    }
}
