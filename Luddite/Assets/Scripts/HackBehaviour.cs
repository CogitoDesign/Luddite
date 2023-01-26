using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class HackBehaviour : MonoBehaviour
{

    public GameManager gameManager;

    //may need to delete these arrays

    public Button[] buttonOne;
    public Button[] buttonTwo;
    public Button[] buttonThree;
    public Button[] buttonFour;
    public Button[] buttonFive;
    public Button[] buttonSix;

    public GameObject[] box1;
    public GameObject[] box2;
    public GameObject[] box3;
    public GameObject[] box4;
    public GameObject[] box5;
    public GameObject[] box6;

    private bool buttonOne1isDone;
    private bool buttonOne2isDone;
    private bool buttonOne3isDone;
    private bool buttonOne4isDone;

    public GameObject cross11;
    public GameObject cross12;
    public GameObject cross13;
    public GameObject cross14;

    private bool buttonTwo1isDone;
    private bool buttonTwo2isDone;
    private bool buttonTwo3isDone;
    private bool buttonTwo4isDone;
    private bool buttonTwo5isDone;

    public GameObject cross21;
    public GameObject cross22;
    public GameObject cross23;
    public GameObject cross24;
    public GameObject cross25;

    private bool buttonThree1isDone;
    private bool buttonThree2isDone;
    private bool buttonThree3isDone;
    private bool buttonThree4isDone;

    public GameObject cross31;
    public GameObject cross32;
    public GameObject cross33;
    public GameObject cross34;

    private bool buttonFour1isDone;
    private bool buttonFour2isDone;
    private bool buttonFour3isDone;
    private bool buttonFour4isDone;
    private bool buttonFour5isDone;

    public GameObject cross41;
    public GameObject cross42;
    public GameObject cross43;
    public GameObject cross44;
    public GameObject cross45;

    private bool buttonFive1isDone;
    private bool buttonFive2isDone;
    private bool buttonFive3isDone;
    private bool buttonFive4isDone;
    private bool buttonFive5isDone;
    private bool buttonFive6isDone;

    public GameObject cross51;
    public GameObject cross52;
    public GameObject cross53;
    public GameObject cross54;
    public GameObject cross55;
    public GameObject cross56;

    private bool buttonSix1isDone;
    private bool buttonSix2isDone;
    private bool buttonSix3isDone;
    private bool buttonSix4isDone;
    private bool buttonSix5isDone;
    private bool buttonSix6isDone;
    private bool buttonSix7isDone;

    public GameObject cross61;
    public GameObject cross62;
    public GameObject cross63;
    public GameObject cross64;
    public GameObject cross65;
    public GameObject cross66;
    public GameObject cross67;

    public bool hasTool1;
    public bool hasTool2;
    public bool hasTool3;
    public bool hasTool4;
    public bool hasTool5;
    public bool hasTool6;

    private bool damageBonus1;
    private bool damageBonus2;
    private int damageBonus1count = 1;
    private int damageBonus2count = 1;

    private bool doubleEnergybool;

    public GameObject doubleEnergybutton;

    // 1 buttons

    public void Number1IsClicked1()
    {

        buttonOne[0].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonOne1isDone = true;
        buttonOne[0].GetComponent<Button>().interactable = false;
        cross11.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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

        doubleEnergybool = false;

    }

    public void Number1IsClicked2()
    {

        buttonOne[1].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonOne2isDone = true;
        buttonOne[1].GetComponent<Button>().interactable = false;
        cross12.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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

        doubleEnergybool = false;

    }

    public void Number1IsClicked3()
    {

        buttonOne[2].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonOne3isDone = true;
        buttonOne[2].GetComponent<Button>().interactable = false;
        cross13.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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

        doubleEnergybool = false;

    }

    public void Number1IsClicked4()
    {

        buttonOne[3].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonOne4isDone = true;
        buttonOne[3].GetComponent<Button>().interactable = false;
        cross14.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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

        doubleEnergybool = false;

    }

    //2 buttons

    public void Number2IsClicked1()
    {

        buttonTwo[0].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonTwo1isDone = true;
        buttonTwo[0].GetComponent<Button>().interactable = false;
        cross21.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;

    }

    public void Number2IsClicked2()
    {

        buttonTwo[1].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonTwo2isDone = true;
        buttonTwo[1].GetComponent<Button>().interactable = false;
        cross22.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number2IsClicked3()
    {

        buttonTwo[2].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonTwo3isDone = true;
        buttonTwo[2].GetComponent<Button>().interactable = false;
        cross23.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;

    }

    public void Number2IsClicked4()
    {

        buttonTwo[3].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonTwo4isDone = true;
        buttonTwo[3].GetComponent<Button>().interactable = false;
        cross24.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number2IsClicked5()
    {

        buttonTwo[4].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonTwo5isDone = true;
        buttonTwo[4].GetComponent<Button>().interactable = false;
        cross25.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;

    }

    //3 buttons

    public void Number3IsClicked1()
    {

        buttonThree[0].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonThree1isDone = true;
        buttonThree[0].GetComponent<Button>().interactable = false;
        cross31.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number3IsClicked2()
    {

        buttonThree[1].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonThree2isDone = true;
        buttonThree[1].GetComponent<Button>().interactable = false;
        cross32.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number3IsClicked3()
    {

        buttonThree[2].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonThree3isDone = true;
        buttonThree[2].GetComponent<Button>().interactable = false;
        cross33.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;

    }

    public void Number3IsClicked4()
    {

        buttonThree[3].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonThree4isDone = true;
        buttonThree[3].GetComponent<Button>().interactable = false;
        cross34.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    //4 buttons

    public void Number4IsClicked1()
    {

        buttonFour[0].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFour1isDone = true;
        buttonFour[0].GetComponent<Button>().interactable = false;
        cross41.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;

    }

    public void Number4IsClicked2()
    {

        buttonFour[1].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFour2isDone = true;
        buttonFour[1].GetComponent<Button>().interactable = false;
        cross42.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;

    }

    public void Number4IsClicked3()
    {

        buttonFour[2].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFour3isDone = true;
        buttonFour[2].GetComponent<Button>().interactable = false;
        cross43.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;

    }

    public void Number4IsClicked4()
    {

        buttonFour[3].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFour4isDone = true;
        buttonFour[3].GetComponent<Button>().interactable = false;
        cross44.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;

    }

    public void Number4IsClicked5()
    {

        buttonFour[4].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFour5isDone = true;
        buttonFour[4].GetComponent<Button>().interactable = false;
        cross45.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    //5 buttons

    public void Number5IsClicked1()
    {

        buttonFive[0].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFive1isDone = true;
        buttonFive[0].GetComponent<Button>().interactable = false;
        cross51.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number5IsClicked2()
    {

        buttonFive[1].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFive2isDone = true;
        buttonFive[1].GetComponent<Button>().interactable = false;
        cross52.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number5IsClicked3()
    {

        buttonFive[2].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFive3isDone = true;
        buttonFive[2].GetComponent<Button>().interactable = false;
        cross53.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number5IsClicked4()
    {

        buttonFive[3].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFive4isDone = true;
        buttonFive[3].GetComponent<Button>().interactable = false;
        cross54.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number5IsClicked5()
    {

        buttonFive[4].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFive5isDone = true;
        buttonFive[4].GetComponent<Button>().interactable = false;
        cross55.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number5IsClicked6()
    {

        buttonFive[5].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonFive6isDone = true;
        buttonFive[5].GetComponent<Button>().interactable = false;
        cross56.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    //6 buttons

    public void Number6IsClicked1()
    {

        buttonSix[0].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonSix1isDone = true;
        buttonSix[0].GetComponent<Button>().interactable = false;
        cross61.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number6IsClicked2()
    {

        buttonSix[1].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonSix2isDone = true;
        buttonSix[1].GetComponent<Button>().interactable = false;
        cross62.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number6IsClicked3()
    {

        buttonSix[2].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonSix3isDone = true;
        buttonSix[2].GetComponent<Button>().interactable = false;
        cross63.SetActive(true);
        ToolCheck();

        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number6IsClicked4()
    {

        buttonSix[3].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonSix4isDone = true;
        buttonSix[3].GetComponent<Button>().interactable = false;
        cross64.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number6IsClicked5()
    {

        buttonSix[4].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonSix5isDone = true;
        buttonSix[4].GetComponent<Button>().interactable = false;
        cross65.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number6IsClicked6()
    {

        buttonSix[5].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonSix6isDone = true;
        buttonSix[5].GetComponent<Button>().interactable = false;
        cross66.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    public void Number6IsClicked7()
    {

        buttonSix[6].GetComponent<Image>().color = new Color(0, 255, 0);
        buttonSix7isDone = true;
        buttonSix[6].GetComponent<Button>().interactable = false;
        cross67.SetActive(true);
        ToolCheck();


        if (doubleEnergybool == false)
        {
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
        doubleEnergybool = false;
    }

    //Check if tool is gained

    public void ToolCheck()
    {
        if (buttonFour1isDone == true && buttonSix1isDone == true && buttonThree2isDone == true && buttonFour3isDone == true)
        {
            hasTool1 = true;
        }

        if (buttonThree3isDone == true && buttonSix2isDone == true && buttonOne1isDone == true && buttonFive3isDone == true)
        {
            hasTool2 = true;
        }

        if (buttonOne1isDone == true && buttonSix3isDone == true && buttonTwo2isDone == true && buttonThree4isDone == true)
        {
            hasTool3 = true;
        }

        if (buttonFive4isDone == true && buttonSix5isDone == true && buttonOne4isDone == true && buttonFive6isDone == true)
        {
            hasTool4 = true;
        }

        if (buttonFive5isDone == true && buttonTwo4isDone == true && buttonSix7isDone == true && buttonTwo5isDone == true)
        {
            hasTool5 = true;
        }
        if(buttonOne3isDone == true && buttonOne4isDone == true && buttonSix6isDone == true && buttonFour5isDone == true && buttonSix7isDone == true)
        {
            hasTool6 = true;
        }

        if(buttonSix4isDone == true && buttonOne2isDone == true)
        {
            gameManager.AddCredit();
        }
        if(buttonFour2isDone == true && buttonThree1isDone == true && buttonFive1isDone == true && buttonTwo1isDone == true && buttonThree2isDone == true && buttonFive2isDone == true)
        {
            damageBonus1 = true;
            
            increaseDamage();
            

        }
        if(buttonTwo3isDone == true && buttonFive4isDone == true && buttonThree4isDone == true && buttonFour4isDone == true && buttonFive5isDone == true && buttonOne2isDone == true)
        {
            damageBonus2 = true;
            
            increaseDamage();
            

        }
    }

    private void increaseDamage()
    {
        if (damageBonus1 == true && damageBonus1count == 1)
        {
            gameManager.damageNumber += 8;
            damageBonus1count = 2;

        }

        if (damageBonus2 == true && damageBonus2count == 1)
        {
            gameManager.damageNumber += 8;
            damageBonus2count = 2;
        }
    }

    public void DoubleEnergyIsClicked()
    {
        gameManager.energyNumber -= 2;
        doubleEnergybool = true;

        foreach (GameObject box in box1)
        {
            box.SetActive(true);
        }
        foreach (GameObject box in box2)
        {
            box.SetActive(true);
        }

        foreach (GameObject box in box3)
        {
            box.SetActive(true);
        }

        foreach (GameObject box in box4)
        {
            box.SetActive(true);
        }

        foreach (GameObject box in box5)
        {
            box.SetActive(true);
        }

        foreach (GameObject box in box6)
        {
            box.SetActive(true);
        }
    }

    // Update is called once per frame
    //for each loop makes all gameobjects active when hasNumber is true and all others off last turns all off when no die active
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().hasOne == true && doubleEnergybool == false)
        {
            foreach (GameObject box in box1)
            {
                box.SetActive(true);
            }

            foreach (GameObject box in box2)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box3)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box4)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box5)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box6)
            {
                box.SetActive(false);
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasTwo == true && doubleEnergybool == false)
        {
            foreach (GameObject box in box1)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box2)
            {
                box.SetActive(true);
            }

            foreach (GameObject box in box3)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box4)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box5)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box6)
            {
                box.SetActive(false);
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasThree == true && doubleEnergybool == false)
        {
            foreach (GameObject box in box1)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box2)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box3)
            {
                box.SetActive(true);
            }

            foreach (GameObject box in box4)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box5)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box6)
            {
                box.SetActive(false);
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasFour == true && doubleEnergybool == false)
        {

            foreach (GameObject box in box1)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box2)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box3)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box4)
            {
                box.SetActive(true);
            }

            foreach (GameObject box in box5)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box6)
            {
                box.SetActive(false);
            }

        }
        else if (gameManager.GetComponent<GameManager>().hasFive == true && doubleEnergybool == false)
        {
            foreach(GameObject box in box1)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box2)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box3)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box4)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box5)
            {
                box.SetActive(true);
            }

            foreach (GameObject box in box6)
            {
                box.SetActive(false);
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasSix == true && doubleEnergybool == false)
        {
            foreach (GameObject box in box1)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box2)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box3)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box4)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box5)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box6)
            {
                box.SetActive(true);
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasOne == false && gameManager.GetComponent<GameManager>().hasTwo == false && gameManager.GetComponent<GameManager>().hasThree == false && gameManager.GetComponent<GameManager>().hasFour == false && gameManager.GetComponent<GameManager>().hasFive == false && gameManager.GetComponent<GameManager>().hasSix == false && doubleEnergybool == false)
        {
            foreach (GameObject box in box1)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box2)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box3)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box4)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box5)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box6)
            {
                box.SetActive(false);
            }
        }

        //check if double energy button should be on

        if(gameManager.energyNumber >= 2)
        {
            doubleEnergybutton.SetActive(true);
        }
        else
        {
            doubleEnergybutton.SetActive(false);
        }

    }
}
