using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level2HackScript : MonoBehaviour
{
    //from old HAck script

    public GameManager gameManager;

    public NeetleBehaviour neetleBehaviour;

    private bool doubleEnergybool;

    public GameObject doubleEnergybutton;

    public AudioSource miniBonus;
    public AudioSource bonusSFX;

    public GameObject tool1;
    public GameObject tool2;
    public GameObject tool3;
    public GameObject tool4;
    public GameObject tool5;
    public GameObject tool6;

    public GameObject tool1BLUE;
    public GameObject tool2BLUE;
    public GameObject tool3BLUE;
    public GameObject tool4BLUE;
    public GameObject tool5BLUE;
    public GameObject tool6BLUE;

    public bool[] bonuses;

    //general stuff

    public int currentSelectedDieNumber;



    //Tool1Items

    public int toolOneCurrentValue;

    public GameObject tool1Box1;

    public Button[] toolOne;

    public bool hasTool1;

    public GameObject tool1Box1Text;
    public GameObject tool1Box2Text;
    public GameObject tool1Box3Text;
    public GameObject tool1Box4Text;

    private bool toolOneBox1isDone;

    public bool toolOneCanStillBeCompleted;

    private bool tool1Test1;
    
    private bool canAddDieToToolOne;

    public int numberOfToolOneBoxesUsed;

    //Tool 2 items

    public int toolTwoCurrentValue;

    public GameObject tool2Box;

    public Button[] toolTwo;

    public bool hasTool2;

    public GameObject tool2Box1Text;
    public GameObject tool2Box2Text;
    public GameObject tool2Box3Text;
    public GameObject tool2Box4Text;

    private bool toolTwoBoxisDone;

    public bool toolTwoCanStillBeCompleted;

    private bool tool2Test;

    private bool canAddDieToToolTwo;

    public int numberOfToolTwoBoxesUsed;


    //Tool 3 items

    public int toolThreeCurrentValue;

    public GameObject tool3Box;

    public Button[] toolThree;

    public bool hasTool3;

    public GameObject tool3Box1Text;
    public GameObject tool3Box2Text;
    public GameObject tool3Box3Text;
    public GameObject tool3Box4Text;

    private bool toolThreeBoxisDone;

    public bool toolThreeCanStillBeCompleted;

    private bool tool3Test;

    private bool canAddDieToToolThree;

    public int numberOfToolThreeBoxesUsed;

    //Tool 4 items

    public int toolFourCurrentValue;

    public GameObject tool4Box;

    public Button[] toolFour;

    public bool hasTool4;

    public GameObject tool4Box1Text;
    public GameObject tool4Box2Text;
    public GameObject tool4Box3Text;
    public GameObject tool4Box4Text;

    private bool toolFourBoxisDone;

    public bool toolFourCanStillBeCompleted;

    private bool tool4Test;

    private bool canAddDieToToolFour;

    public int numberOfToolFourBoxesUsed;

    //Tool 5 items

    public int toolFiveCurrentValue;

    public GameObject tool5Box;

    public Button[] toolFive;

    public bool hasTool5;

    public GameObject tool5Box1Text;
    public GameObject tool5Box2Text;
    public GameObject tool5Box3Text;
    public GameObject tool5Box4Text;

    private bool toolFiveBoxisDone;

    public bool toolFiveCanStillBeCompleted;

    private bool tool5Test;

    private bool canAddDieToToolFive;

    public int numberOfToolFiveBoxesUsed;

    //Tool 6 items

    public int toolSixCurrentValue;

    public GameObject tool6Box;

    public Button[] toolSix;

    public bool hasTool6;

    public GameObject tool6Box1Text;
    public GameObject tool6Box2Text;
    public GameObject tool6Box3Text;
    public GameObject tool6Box4Text;

    private bool toolSixBoxisDone;

    public bool toolSixCanStillBeCompleted;

    private bool tool6Test;

    private bool canAddDieToToolSix;

    public int numberOfToolSixBoxesUsed;

    //Double Credit Items

    public int doubleCreditCurrentValue;

    public GameObject doubleCreditBox;

    public Button[] doubleCredit;

    public bool hasDoubleCredit;

    public GameObject doubleCreditBox1Text;
    public GameObject doubleCreditBox2Text;
    public GameObject doubleCreditBox3Text;
    public GameObject doubleCreditBox4Text;

    private bool doubleCreditBoxisDone;

    public bool doubleCreditCanStillBeCompleted;

    private bool doubleCreditTest;

    private bool canAddDieToDoubleCredit;

    public int numberOfDoubleCreditBoxesUsed;

    //8 Damage 1 items

    public int eightDamageOneCurrentValue;

    public GameObject eightDamageOneBox;

    public Button[] eightDamageOne;

    public bool hasEightDamageOne;

    public GameObject eightDamageOneBox1Text;
    public GameObject eightDamageOneBox2Text;
    public GameObject eightDamageOneBox3Text;
    public GameObject eightDamageOneBox4Text;

    private bool eightDamageOneBoxisDone;

    public bool eightDamageOneCanStillBeCompleted;

    private bool eightDamageOneTest;

    private bool canAddDieToEightDamageOne;

    public int numberOfEightDamageOneBoxesUsed;


    //8 Damage 2 items

    public int eightDamageTwoCurrentValue;

    public GameObject eightDamageTwoBox;

    public Button[] eightDamageTwo;

    public bool hasEightDamageTwo;

    public GameObject eightDamageTwoBox1Text;
    public GameObject eightDamageTwoBox2Text;
    public GameObject eightDamageTwoBox3Text;
    public GameObject eightDamageTwoBox4Text;

    private bool eightDamageTwoBoxisDone;

    public bool eightDamageTwoCanStillBeCompleted;

    private bool eightDamageTwoTest;

    private bool canAddDieToEightDamageTwo;

    public int numberOfEightDamageTwoBoxesUsed;


    //The instructions for each of the hac scren buttons when clicked.


    //Buttons Clicked - Tool One 

    public void Tool1Box1isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            miniBonus.Play();
            
            numberOfToolOneBoxesUsed += 1;
            
            if (numberOfToolOneBoxesUsed == 1)
            {
                tool1Box1Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool1Box1Text.SetActive(true);
            }
            else if (numberOfToolOneBoxesUsed == 2)
            {
                tool1Box2Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool1Box2Text.SetActive(true);
            }
            else if (numberOfToolOneBoxesUsed == 3)
            {
                tool1Box3Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool1Box3Text.SetActive(true);
            }
            else if (numberOfToolOneBoxesUsed == 4)
            {
                tool1Box4Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool1Box4Text.SetActive(true);
                toolOneBox1isDone = true;
                hasTool1 = true;
                toolOne[0].GetComponent<Button>().interactable = false;
            }

            tool1Box1.SetActive(false);
            
            toolOneCurrentValue = toolOneCurrentValue + currentSelectedDieNumber;
            ToolCheck();

            if (doubleEnergybool == false)
            {
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
            }

            doubleEnergybool = false;
        }
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void Tool2BoxisClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            miniBonus.Play();

            numberOfToolTwoBoxesUsed += 1;

            if (numberOfToolTwoBoxesUsed == 1)
            {
                tool2Box1Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool2Box1Text.SetActive(true);
            }
            else if (numberOfToolTwoBoxesUsed == 2)
            {
                tool2Box2Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool2Box2Text.SetActive(true);
            }
            else if (numberOfToolTwoBoxesUsed == 3)
            {
                tool2Box3Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool2Box3Text.SetActive(true);
            }
            else if (numberOfToolTwoBoxesUsed == 4)
            {
                tool2Box4Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool2Box4Text.SetActive(true);
                toolTwoBoxisDone = true;
                hasTool2 = true;
                toolTwo[0].GetComponent<Button>().interactable = false;
            }

            tool2Box.SetActive(false);

            toolTwoCurrentValue = toolTwoCurrentValue + currentSelectedDieNumber;
            ToolCheck();

            if (doubleEnergybool == false)
            {
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
            }

            doubleEnergybool = false;
        }
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void Tool3BoxisClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            miniBonus.Play();

            numberOfToolThreeBoxesUsed += 1;

            if (numberOfToolThreeBoxesUsed == 1)
            {
                tool3Box1Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool3Box1Text.SetActive(true);
            }
            else if (numberOfToolThreeBoxesUsed == 2)
            {
                tool3Box2Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool3Box2Text.SetActive(true);
            }
            else if (numberOfToolThreeBoxesUsed == 3)
            {
                tool3Box3Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool3Box3Text.SetActive(true);
            }
            else if (numberOfToolThreeBoxesUsed == 4)
            {
                tool3Box4Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool3Box4Text.SetActive(true);
                toolThreeBoxisDone = true;
                hasTool3 = true;
                toolThree[0].GetComponent<Button>().interactable = false;
            }

            tool3Box.SetActive(false);

            toolThreeCurrentValue = toolThreeCurrentValue + currentSelectedDieNumber;
            ToolCheck();

            if (doubleEnergybool == false)
            {
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
            }

            doubleEnergybool = false;
        }
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void Tool4BoxisClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            miniBonus.Play();

            numberOfToolFourBoxesUsed += 1;

            if (numberOfToolFourBoxesUsed == 1)
            {
                tool4Box1Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool4Box1Text.SetActive(true);
            }
            else if (numberOfToolFourBoxesUsed == 2)
            {
                tool4Box2Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool4Box2Text.SetActive(true);
            }
            else if (numberOfToolFourBoxesUsed == 3)
            {
                tool4Box3Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool4Box3Text.SetActive(true);
            }
            else if (numberOfToolFourBoxesUsed == 4)
            {
                tool4Box4Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool4Box4Text.SetActive(true);
                toolFourBoxisDone = true;
                hasTool4 = true;
                toolFour[0].GetComponent<Button>().interactable = false;
            }

            tool4Box.SetActive(false);

            toolFourCurrentValue = toolFourCurrentValue + currentSelectedDieNumber;
            ToolCheck();

            if (doubleEnergybool == false)
            {
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
            }

            doubleEnergybool = false;
        }
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void Tool5BoxisClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            miniBonus.Play();

            numberOfToolFiveBoxesUsed += 1;

            if (numberOfToolFiveBoxesUsed == 1)
            {
                tool5Box1Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool5Box1Text.SetActive(true);
            }
            else if (numberOfToolFiveBoxesUsed == 2)
            {
                tool5Box2Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool5Box2Text.SetActive(true);
            }
            else if (numberOfToolFiveBoxesUsed == 3)
            {
                tool5Box3Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool5Box3Text.SetActive(true);
            }
            else if (numberOfToolFiveBoxesUsed == 4)
            {
                tool5Box4Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool5Box4Text.SetActive(true);
                toolFiveBoxisDone = true;
                hasTool5 = true;
                toolFive[0].GetComponent<Button>().interactable = false;
            }

            tool5Box.SetActive(false);

            toolFiveCurrentValue = toolFiveCurrentValue + currentSelectedDieNumber;
            ToolCheck();

            if (doubleEnergybool == false)
            {
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
            }

            doubleEnergybool = false;
        }
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void Tool6BoxisClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            miniBonus.Play();

            numberOfToolSixBoxesUsed += 1;

            if (numberOfToolSixBoxesUsed == 1)
            {
                tool6Box1Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool6Box1Text.SetActive(true);
            }
            else if (numberOfToolSixBoxesUsed == 2)
            {
                tool6Box2Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool6Box2Text.SetActive(true);
            }
            else if (numberOfToolSixBoxesUsed == 3)
            {
                tool6Box3Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool6Box3Text.SetActive(true);
            }
            else if (numberOfToolSixBoxesUsed == 4)
            {
                tool6Box4Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                tool6Box4Text.SetActive(true);
                toolSixBoxisDone = true;
                hasTool6 = true;
                toolSix[0].GetComponent<Button>().interactable = false;
            }

            tool6Box.SetActive(false);

            toolSixCurrentValue = toolSixCurrentValue + currentSelectedDieNumber;
            ToolCheck();

            if (doubleEnergybool == false)
            {
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
            }

            doubleEnergybool = false;
        }
        else
        {
            gameManager.ClockErrorScreen();
        }
    }


    public void doubleCreditBoxisClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            miniBonus.Play();

            numberOfDoubleCreditBoxesUsed += 1;

            if (numberOfDoubleCreditBoxesUsed == 1)
            {
                doubleCreditBox1Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                doubleCreditBox1Text.SetActive(true);
            }
            else if (numberOfDoubleCreditBoxesUsed == 2)
            {
                doubleCreditBox2Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                doubleCreditBox2Text.SetActive(true);
            }
            else if (numberOfDoubleCreditBoxesUsed == 3)
            {
                doubleCreditBox3Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                doubleCreditBox3Text.SetActive(true);
            }
            else if (numberOfDoubleCreditBoxesUsed == 4)
            {
                doubleCreditBox4Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                doubleCreditBox4Text.SetActive(true);
                doubleCreditBoxisDone = true;
                hasDoubleCredit = true;
                doubleCredit[0].GetComponent<Button>().interactable = false;
            }

            doubleCreditBox.SetActive(false);

            doubleCreditCurrentValue = doubleCreditCurrentValue + currentSelectedDieNumber;
            ToolCheck();

            if (doubleEnergybool == false)
            {
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
            }

            doubleEnergybool = false;
        }
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void eightDamageOneBoxisClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            miniBonus.Play();

            numberOfEightDamageOneBoxesUsed += 1;

            if (numberOfEightDamageOneBoxesUsed == 1)
            {
                eightDamageOneBox1Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                eightDamageOneBox1Text.SetActive(true);
            }
            else if (numberOfEightDamageOneBoxesUsed == 2)
            {
                eightDamageOneBox2Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                eightDamageOneBox2Text.SetActive(true);
            }
            else if (numberOfEightDamageOneBoxesUsed == 3)
            {
                eightDamageOneBox3Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                eightDamageOneBox3Text.SetActive(true);
            }
            else if (numberOfEightDamageOneBoxesUsed == 4)
            {
                eightDamageOneBox4Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                eightDamageOneBox4Text.SetActive(true);
                eightDamageOneBoxisDone = true;
                hasEightDamageOne = true;
                eightDamageOne[0].GetComponent<Button>().interactable = false;
            }

            eightDamageOneBox.SetActive(false);

            eightDamageOneCurrentValue = eightDamageOneCurrentValue + currentSelectedDieNumber;
            ToolCheck();

            if (doubleEnergybool == false)
            {
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
            }

            doubleEnergybool = false;
        }
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void eightDamageTwoBoxisClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            miniBonus.Play();

            numberOfEightDamageTwoBoxesUsed += 1;

            if (numberOfEightDamageTwoBoxesUsed == 1)
            {
                eightDamageTwoBox1Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                eightDamageTwoBox1Text.SetActive(true);
            }
            else if (numberOfEightDamageTwoBoxesUsed == 2)
            {
                eightDamageTwoBox2Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                eightDamageTwoBox2Text.SetActive(true);
            }
            else if (numberOfEightDamageTwoBoxesUsed == 3)
            {
                eightDamageTwoBox3Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                eightDamageTwoBox3Text.SetActive(true);
            }
            else if (numberOfEightDamageTwoBoxesUsed == 4)
            {
                eightDamageTwoBox4Text.GetComponent<TextMeshProUGUI>().text = currentSelectedDieNumber.ToString();
                eightDamageTwoBox4Text.SetActive(true);
                eightDamageTwoBoxisDone = true;
                hasEightDamageTwo = true;
                eightDamageTwo[0].GetComponent<Button>().interactable = false;
            }

            eightDamageTwoBox.SetActive(false);

            eightDamageTwoCurrentValue = eightDamageTwoCurrentValue + currentSelectedDieNumber;
            ToolCheck();

            if (doubleEnergybool == false)
            {
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
            }

            doubleEnergybool = false;
        }
        else
        {
            gameManager.ClockErrorScreen();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        numberOfToolOneBoxesUsed = 0;
        toolOneCurrentValue = 0;

        numberOfToolTwoBoxesUsed = 0;
        toolTwoCurrentValue = 0;

        numberOfToolThreeBoxesUsed = 0;
        toolThreeCurrentValue = 0;

        numberOfToolFourBoxesUsed = 0;
        toolFourCurrentValue = 0;

        numberOfToolFiveBoxesUsed = 0;
        toolFiveCurrentValue = 0;

        numberOfToolSixBoxesUsed = 0;
        toolSixCurrentValue = 0;

        numberOfDoubleCreditBoxesUsed = 0;
        doubleCreditCurrentValue = 0;

        numberOfEightDamageOneBoxesUsed = 0;
        eightDamageOneCurrentValue = 0;

        numberOfEightDamageTwoBoxesUsed = 0;
        eightDamageTwoCurrentValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        

        //Track current selected die number and show boxes that haven't been clicked or exceed amount needed

        if (gameManager.hasOne)
        {
            currentSelectedDieNumber = 1;
            //Check if each box should be visible
            Tool1Box1Check();
            Tool2BoxCheck();
            Tool3BoxCheck();
            Tool4BoxCheck();
            Tool5BoxCheck();
            Tool6BoxCheck();

            DoubleCreditBoxCheck();
            EightDamageOneBoxCheck();
            EightDamageTwoBoxCheck();


        }
        else if (gameManager.hasTwo)
        {
            currentSelectedDieNumber = 2;
            Tool1Box1Check();
            Tool2BoxCheck();
            Tool3BoxCheck();
            Tool4BoxCheck();
            Tool5BoxCheck();
            Tool6BoxCheck();

            DoubleCreditBoxCheck();
            EightDamageOneBoxCheck();
            EightDamageTwoBoxCheck();

        }
        else if (gameManager.hasThree)
        {
            currentSelectedDieNumber = 3;
            Tool1Box1Check();
            Tool2BoxCheck();
            Tool3BoxCheck();
            Tool4BoxCheck();
            Tool5BoxCheck();
            Tool6BoxCheck();

            DoubleCreditBoxCheck();
            EightDamageOneBoxCheck();
            EightDamageTwoBoxCheck();

        }
        else if (gameManager.hasFour)
        {
            currentSelectedDieNumber = 4;
            Tool1Box1Check();
            Tool2BoxCheck();
            Tool3BoxCheck();
            Tool4BoxCheck();
            Tool5BoxCheck();
            Tool6BoxCheck();

            DoubleCreditBoxCheck();
            EightDamageOneBoxCheck();
            EightDamageTwoBoxCheck();

        }
        else if (gameManager.hasFive)
        {
            currentSelectedDieNumber = 5;
            Tool1Box1Check();
            Tool2BoxCheck();
            Tool3BoxCheck();
            Tool4BoxCheck();
            Tool5BoxCheck();
            Tool6BoxCheck();

            DoubleCreditBoxCheck();
            EightDamageOneBoxCheck();
            EightDamageTwoBoxCheck();

        }
        else if (gameManager.hasSix)
        {
            currentSelectedDieNumber = 6;
            Tool1Box1Check();
            Tool2BoxCheck();
            Tool3BoxCheck();
            Tool4BoxCheck();
            Tool5BoxCheck();
            Tool6BoxCheck();

            DoubleCreditBoxCheck();
            EightDamageOneBoxCheck();
            EightDamageTwoBoxCheck();

        }
        else
        {
            tool1Box1.SetActive(false);
            tool2Box.SetActive(false);
            tool3Box.SetActive(false);
            tool4Box.SetActive(false);
            tool5Box.SetActive(false);
            tool6Box.SetActive(false);

            doubleCreditBox.SetActive(false);
            eightDamageOneBox.SetActive(false);
            eightDamageTwoBox.SetActive(false);
 
        }


    }




    //Check if tool is gained

    public void ToolCheck()
    {
        
        if (hasTool1)
        {
            if (neetleBehaviour.GetComponent<NeetleBehaviour>().tool1done == false)
            {
                if (bonuses[0] == false)
                {
                    bonuses[0] = true;
                    hasTool1 = true;
                    tool1.SetActive(false);
                    tool1BLUE.SetActive(true);
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
            }
        }

        if (hasTool2)
        {
            if (neetleBehaviour.GetComponent<NeetleBehaviour>().tool2done == false)
            {
                if (bonuses[1] == false)
                {
                    bonuses[1] = true;
                    hasTool2 = true;
                    tool2.SetActive(false);
                    tool2BLUE.SetActive(true);
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
            }
        }

        if (hasTool3)
        {
            if (neetleBehaviour.GetComponent<NeetleBehaviour>().tool3done == false)
            {
                if (bonuses[2] == false)
                {
                    bonuses[2] = true;
                    hasTool3 = true;
                    tool3.SetActive(false);
                    tool3BLUE.SetActive(true);
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
            }
        }

        if (hasTool4)
        {
            if (neetleBehaviour.GetComponent<NeetleBehaviour>().tool6done == false)
            {
                if (bonuses[3] == false)
                {
                    bonuses[3] = true;
                    hasTool4 = true;
                    tool6.SetActive(false);
                    tool6BLUE.SetActive(true);
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
            }
        }

        if (hasTool5)
        {
            if (neetleBehaviour.GetComponent<NeetleBehaviour>().tool4done == false)
            {
                if (bonuses[4] == false)
                {
                    bonuses[4] = true;
                    hasTool5 = true;
                    tool4.SetActive(false);
                    tool4BLUE.SetActive(true);
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
            }
        }

        if (hasTool6)
        {
            if (neetleBehaviour.GetComponent<NeetleBehaviour>().tool5done == false)
            {
                if (bonuses[5] == false)
                {
                    bonuses[5] = true;
                    hasTool6 = true;
                    tool5.SetActive(false);
                    tool5BLUE.SetActive(true);
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
            }
        }

        if (hasDoubleCredit)
        {
                if (bonuses[6] == false)
                {
                    bonuses[6] = true;
                    hasDoubleCredit = true;
                    gameManager.creditNumber += 2;
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
        }

        if (hasEightDamageOne)
        {
            if (bonuses[7] == false)
            {
                bonuses[7] = true;
                hasEightDamageOne = true;
                gameManager.damageNumber += 8;
                gameManager.hackDamage += 8;
                StartCoroutine(playBonusWithDelay(0.5f));
            }
        }

        if (hasEightDamageTwo)
        {
            if (bonuses[8] == false)
            {
                bonuses[8] = true;
                hasEightDamageTwo = true;
                gameManager.damageNumber += 8;
                gameManager.hackDamage += 8;
                StartCoroutine(playBonusWithDelay(0.5f));
            }
        }
    }


    /*
    COULD TRY THIS IF THE ABOVE DOESNT WORK

    if (hasDoubleCredit)
    {
        if (bonuses[6] == false)
        {
            bonuses[6] = true;
            gameManager.AddCredit();
            StartCoroutine(playBonusWithDelay(0.5f));
        }
    }

    if (hasEightDamageOne)
    {
        if (bonuses[7] == false)
        {
            bonuses[7] = true;
            damageBonus1 = true;

            increaseDamage();
            StartCoroutine(playBonusWithDelay(0.5f));
        }


    }
    if (hasEightDamageTwo)
    {
        if (bonuses[8] == false)
        {
            bonuses[8] = true;
            damageBonus2 = true;

            increaseDamage();
            StartCoroutine(playBonusWithDelay(1));
        }

    }
    */




    //Check if boxes can be shown

    public void CheckToolOneDie()
    {
        tool1Test1 = true;

        //checks that fourth box must add up to correct number (in this case 12)
        if (numberOfToolOneBoxesUsed == 3)
        {
            if ((toolOneCurrentValue + currentSelectedDieNumber) == 12)
            {
                tool1Test1 = true;
                
            }
            else
            {
                tool1Test1 = false;
                
            }
        }

        /*
        //checks to see you don't go too high on third box
        if (numberOfToolOneBoxesUsed == 2)
        {
            if ((toolOneCurrentValue + currentSelectedDieNumber) >= 11)
            {
                tool1Test1 = false;
                
            }
            else
            {
                tool1Test1 = true;
                
            }
        }
        //checks to see you don't go too low on third box
        if (numberOfToolOneBoxesUsed == 2)
        {
            if ((toolOneCurrentValue + currentSelectedDieNumber) <= 6)
            {
                tool1Test1 = false;
                
            }
            else
            {
                tool1Test1 = true;
                
            }
        }
        //checks to see that you don't go too high on second box
        if (numberOfToolOneBoxesUsed == 1)
        {
            if ((toolOneCurrentValue + currentSelectedDieNumber) <= 10)
            {
                tool1Test1 = true;
                
            }
            else
            {
                tool1Test1 = false;
                
            }
        }
        */


        if (tool1Test1 == false)
        {
            canAddDieToToolOne = false;
        }
        else
        {
            canAddDieToToolOne = true;
        }

    }


    public void CheckToolTwoDie()
    {
        tool2Test = true;

        //checks that fourth box must add up to correct number (in this case 14)
        if (numberOfToolTwoBoxesUsed == 3)
        {
            if ((toolTwoCurrentValue + currentSelectedDieNumber) == 14)
            {
                tool2Test = true;

            }
            else
            {
                tool2Test = false;

            }
        }

        /*
        //checks to see you don't go too high on third box
        if (numberOfToolTwoBoxesUsed == 2)
        {
            if ((toolTwoCurrentValue + currentSelectedDieNumber) >= 13)
            {
                tool2Test = false;

            }
            else
            {
                tool2Test = true;

            }
        }
        //checks to see you don't go too low on third box
        if (numberOfToolTwoBoxesUsed == 2)
        {
            if ((toolTwoCurrentValue + currentSelectedDieNumber) <= 8)
            {
                tool2Test = false;

            }
            else
            {
                tool2Test = true;

            }
        }
        */
        
        if (tool2Test == false)
        {
            canAddDieToToolTwo = false;
        }
        else
        {
            canAddDieToToolTwo = true;
        }

    }


    public void CheckToolThreeDie()
    {
        tool3Test = true;

        //checks that fourth box must add up to correct number (in this case 7)
        if (numberOfToolThreeBoxesUsed == 3)
        {
            if ((toolThreeCurrentValue + currentSelectedDieNumber) == 7)
            {
                tool3Test = true;

            }
            else
            {
                tool3Test = false;

            }
        }
        /*
        //checks to see you don't go too high on third box
        if (numberOfToolThreeBoxesUsed == 2)
        {
            if ((toolThreeCurrentValue + currentSelectedDieNumber) >= 6)
            {
                tool3Test = false;

            }
            else
            {
                tool3Test = true;

            }
        }
        
        //checks to see that you don't go too high on second box
        if (numberOfToolThreeBoxesUsed == 1)
        {
            if ((toolThreeCurrentValue + currentSelectedDieNumber) <= 5)
            {
                tool3Test = true;

            }
            else
            {
                tool3Test = false;

            }
        }

        //checks to see that you don't go too high on first box
        if (numberOfToolThreeBoxesUsed == 0)
        {
            if ((toolThreeCurrentValue + currentSelectedDieNumber) <= 4)
            {
                tool3Test = true;

            }
            else
            {
                tool3Test = false;

            }
        }
        */

        if (tool3Test == false)
        {
            canAddDieToToolThree = false;
        }
        else
        {
            canAddDieToToolThree = true;
        }

    }

    public void CheckToolFourDie()
    {
        tool4Test = true;

        //checks that fourth box must add up to correct number (in this case 20)
        if (numberOfToolFourBoxesUsed == 3)
        {
            if ((toolFourCurrentValue + currentSelectedDieNumber) == 20)
            {
                tool4Test = true;

            }
            else
            {
                tool4Test = false;

            }
        }

        /*
        //checks to see you don't go too low on third box
        if (numberOfToolFourBoxesUsed == 2)
        {
            if ((toolFourCurrentValue + currentSelectedDieNumber) <= 13)
            {
                tool4Test = false;

            }
            else
            {
                tool4Test = true;

            }
        }
        //checks to see you don't go too low on second box
        if (numberOfToolFourBoxesUsed == 1)
        {
            if ((toolFourCurrentValue + currentSelectedDieNumber) <= 7)
            {
                tool4Test = false;

            }
            else
            {
                tool4Test = true;

            }
        }
        
        //checks to see you don't go too low on first box
        if (numberOfToolFourBoxesUsed == 0)
        {
            if ((toolFourCurrentValue + currentSelectedDieNumber) <= 1)
            {
                tool4Test = false;

            }
            else
            {
                tool4Test = true;

            }
        }
        */

        if (tool4Test == false)
        {
            canAddDieToToolFour = false;
        }
        else
        {
            canAddDieToToolFour = true;
        }

    }

    public void CheckToolFiveDie()
    {
        tool5Test = true;

        //checks that fourth box must add up to correct number (in this case 10)
        if (numberOfToolFiveBoxesUsed == 3)
        {
            if ((toolFiveCurrentValue + currentSelectedDieNumber) == 10)
            {
                tool5Test = true;

            }
            else
            {
                tool5Test = false;

            }
        }
        /*
        //checks to see you don't go too high on third box
        if (numberOfToolFiveBoxesUsed == 2)
        {
            if ((toolFiveCurrentValue + currentSelectedDieNumber) >= 9)
            {
                tool5Test = false;

            }
            else
            {
                tool5Test = true;

            }
        }
        //checks to see you don't go too low on third box
        if (numberOfToolFiveBoxesUsed == 2)
        {
            if ((toolFiveCurrentValue + currentSelectedDieNumber) <= 4)
            {
                tool5Test = false;

            }
            else
            {
                tool5Test = true;

            }
        }
        //checks to see that you don't go too high on second box
        if (numberOfToolFiveBoxesUsed == 1)
        {
            if ((toolFiveCurrentValue + currentSelectedDieNumber) <= 8)
            {
                tool5Test = true;

            }
            else
            {
                tool5Test = false;

            }
        }
        */

        if (tool5Test == false)
        {
            canAddDieToToolFive = false;
        }
        else
        {
            canAddDieToToolFive = true;
        }

    }

    public void CheckToolSixDie()
    {
        tool6Test = true;

        //checks that fourth box must add up to correct number (in this case 18)
        if (numberOfToolSixBoxesUsed == 3)
        {
            if ((toolSixCurrentValue + currentSelectedDieNumber) == 18)
            {
                tool6Test = true;

            }
            else
            {
                tool6Test = false;

            }
        }
        /*
        //checks to see you don't go too high on third box
        if (numberOfToolSixBoxesUsed == 2)
        {
            if ((toolSixCurrentValue + currentSelectedDieNumber) >= 17)
            {
                tool6Test = false;

            }
            else
            {
                tool6Test = true;

            }
        }
        //checks to see you don't go too low on third box
        if (numberOfToolSixBoxesUsed == 2)
        {
            if ((toolSixCurrentValue + currentSelectedDieNumber) <= 11)
            {
                tool6Test = false;

            }
            else
            {
                tool6Test = true;

            }
        }
        //checks to see that you don't go too high on second box
        if (numberOfToolSixBoxesUsed == 1)
        {
            if ((toolSixCurrentValue + currentSelectedDieNumber) >= 5)
            {
                tool6Test = true;

            }
            else
            {
                tool6Test = false;

            }
        }
        */

        if (tool6Test == false)
        {
            canAddDieToToolSix = false;
        }
        else
        {
            canAddDieToToolSix = true;
        }

    }

    public void CheckDoubleCreditDie()
    {
        doubleCreditTest = true;

        //checks that fourth box must add up to correct number (in this case 16)
        if (numberOfDoubleCreditBoxesUsed == 3)
        {
            if ((doubleCreditCurrentValue + currentSelectedDieNumber) == 16)
            {
                doubleCreditTest = true;

            }
            else
            {
                doubleCreditTest = false;

            }
        }
        /*
        //checks to see you don't go too high on third box
        if (numberOfDoubleCreditBoxesUsed == 2)
        {
            if ((doubleCreditCurrentValue + currentSelectedDieNumber) >= 15)
            {
                doubleCreditTest = false;

            }
            else
            {
                doubleCreditTest = true;

            }
        }
        //checks to see you don't go too low on third box
        if (numberOfDoubleCreditBoxesUsed == 2)
        {
            if ((doubleCreditCurrentValue + currentSelectedDieNumber) <= 10)
            {
                doubleCreditTest = false;

            }
            else
            {
                doubleCreditTest = true;

            }
        }

        //checks to see you don't go too low on second box
        if (numberOfDoubleCreditBoxesUsed == 1)
        {
            if ((doubleCreditCurrentValue + currentSelectedDieNumber) <= 4)
            {
                doubleCreditTest = false;

            }
            else
            {
                doubleCreditTest = true;

            }
        }
        */

        if (doubleCreditTest == false)
        {
            canAddDieToDoubleCredit = false;
        }
        else
        {
            canAddDieToDoubleCredit = true;
        }

    }

    public void CheckEightDamageOneDie()
    {
        eightDamageOneTest = true;

        //checks that fourth box must add up to correct number (in this case 7)
        if (numberOfEightDamageOneBoxesUsed == 3)
        {
            if ((eightDamageOneCurrentValue + currentSelectedDieNumber) == 7)
            {
                eightDamageOneTest = true;

            }
            else
            {
                eightDamageOneTest = false;

            }
        }
        /*
        //checks to see you don't go too high on third box
        if (numberOfEightDamageOneBoxesUsed == 2)
        {
            if ((eightDamageOneCurrentValue + currentSelectedDieNumber) >= 6)
            {
                eightDamageOneTest = false;

            }
            else
            {
                eightDamageOneTest = true;

            }
        }
        
        //checks to see that you don't go too high on second box
        if (numberOfEightDamageOneBoxesUsed == 1)
        {
            if ((eightDamageOneCurrentValue + currentSelectedDieNumber) <= 5)
            {
                eightDamageOneTest = true;

            }
            else
            {
                eightDamageOneTest = false;

            }
        }


        if (eightDamageOneTest == false)
        {
            canAddDieToEightDamageOne = false;
        }
        else
        {
            canAddDieToEightDamageOne = true;
        }

        //checks to see that you don't go too high on first box
        if (numberOfEightDamageOneBoxesUsed == 0)
        {
            if ((eightDamageOneCurrentValue + currentSelectedDieNumber) <= 4)
            {
                eightDamageOneTest = true;

            }
            else
            {
                eightDamageOneTest = false;

            }
        }
        */

        if (eightDamageOneTest == false)
        {
            canAddDieToEightDamageOne = false;
        }
        else
        {
            canAddDieToEightDamageOne = true;
        }

    }

    public void CheckEightDamageTwoDie()
    {
        eightDamageTwoTest = true;

        //checks that fourth box must add up to correct number (in this case 20)
        if (numberOfEightDamageTwoBoxesUsed == 3)
        {
            if ((eightDamageTwoCurrentValue + currentSelectedDieNumber) == 20)
            {
                eightDamageTwoTest = true;

            }
            else
            {
                eightDamageTwoTest = false;

            }
        }
        /*
        //checks to see you don't go too low on third box
        if (numberOfEightDamageTwoBoxesUsed == 2)
        {
            if ((eightDamageTwoCurrentValue + currentSelectedDieNumber) <= 13)
            {
                eightDamageTwoTest = false;

            }
            else
            {
                eightDamageTwoTest = true;

            }
        }

        //checks to see you don't go too low on second box
        if (numberOfEightDamageTwoBoxesUsed == 1)
        {
            if ((eightDamageTwoCurrentValue + currentSelectedDieNumber) <= 7)
            {
                eightDamageTwoTest = false;

            }
            else
            {
                eightDamageTwoTest = true;

            }
        }

        //checks to see you don't go too low on first box
        if (numberOfEightDamageTwoBoxesUsed == 0)
        {
            if ((eightDamageTwoCurrentValue + currentSelectedDieNumber) <= 1)
            {
                eightDamageTwoTest = false;

            }
            else
            {
                eightDamageTwoTest = true;

            }
        }
        */

        if (eightDamageTwoTest == false)
        {
            canAddDieToEightDamageTwo = false;
        }
        else
        {
            canAddDieToEightDamageTwo = true;
        }

    }

    //Each box needs to be checked to see if it can be made visible this does this
    //Need this for each box in the Hac Screen on each

    //Tool One Boxes

    public void Tool1Box1Check()
    {
        if (toolOneBox1isDone == false)
        {
            CheckToolOneDie();
            if (canAddDieToToolOne)
            {
                tool1Box1.SetActive(true);
            }
            else
            {
                tool1Box1.SetActive(false);
            }

        }
        else
        {
            tool1Box1.SetActive(false);
        }
    }

    //Tool Two Boxes

    public void Tool2BoxCheck()
    {
        if (toolTwoBoxisDone == false)
        {
            CheckToolTwoDie();
            if (canAddDieToToolTwo)
            {
                tool2Box.SetActive(true);
            }
            else
            {
                tool2Box.SetActive(false);
            }

        }
        else
        {
            tool2Box.SetActive(false);
        }
    }

    //Tool Three Boxes

    public void Tool3BoxCheck()
    {
        if (toolThreeBoxisDone == false)
        {
            CheckToolThreeDie();
            if (canAddDieToToolThree)
            {
                tool3Box.SetActive(true);
            }
            else
            {
                tool3Box.SetActive(false);
            }

        }
        else
        {
            tool3Box.SetActive(false);
        }
    }

    //Tool Four Boxes

    public void Tool4BoxCheck()
    {
        if (toolFourBoxisDone == false)
        {
            CheckToolFourDie();
            if (canAddDieToToolFour)
            {
                tool4Box.SetActive(true);
            }
            else
            {
                tool4Box.SetActive(false);
            }

        }
        else
        {
            tool4Box.SetActive(false);
        }
    }

    //Tool Five Boxes

    public void Tool5BoxCheck()
    {
        if (toolFiveBoxisDone == false)
        {
            CheckToolFiveDie();
            if (canAddDieToToolFive)
            {
                tool5Box.SetActive(true);
            }
            else
            {
                tool5Box.SetActive(false);
            }

        }
        else
        {
            tool5Box.SetActive(false);
        }
    }

    //Tool Six Boxes

    public void Tool6BoxCheck()
    {
        if (toolSixBoxisDone == false)
        {
            CheckToolSixDie();
            if (canAddDieToToolSix)
            {
                tool6Box.SetActive(true);
            }
            else
            {
                tool6Box.SetActive(false);
            }

        }
        else
        {
            tool6Box.SetActive(false);
        }
    }

    //Double Credit Boxes

    public void DoubleCreditBoxCheck()
    {
        if (doubleCreditBoxisDone == false)
        {
            CheckDoubleCreditDie();
            if (canAddDieToDoubleCredit)
            {
                doubleCreditBox.SetActive(true);
            }
            else
            {
                doubleCreditBox.SetActive(false);
            }

        }
        else
        {
            doubleCreditBox.SetActive(false);
        }
    }

    //Eight Damage One Boxes

    public void EightDamageOneBoxCheck()
    {
        if (eightDamageOneBoxisDone == false)
        {
            CheckEightDamageOneDie();
            if (canAddDieToEightDamageOne)
            {
                eightDamageOneBox.SetActive(true);
            }
            else
            {
                eightDamageOneBox.SetActive(false);
            }

        }
        else
        {
            eightDamageOneBox.SetActive(false);
        }
    }

    //Eight Damage Two Boxes

    public void EightDamageTwoBoxCheck()
    {
        if (eightDamageTwoBoxisDone == false)
        {
            CheckEightDamageTwoDie();
            if (canAddDieToEightDamageTwo)
            {
                eightDamageTwoBox.SetActive(true);
            }
            else
            {
                eightDamageTwoBox.SetActive(false);
            }

        }
        else
        {
            eightDamageTwoBox.SetActive(false);
        }
    }

    IEnumerator playBonusWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        bonusSFX.Play();
    }


}
