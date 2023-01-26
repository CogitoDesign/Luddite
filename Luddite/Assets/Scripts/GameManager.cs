using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    //stuff
    private int die1Number;
    private int die2Number;
    private int die3Number;

    public GameObject die1;
    public GameObject die2;
    public GameObject die3;

    public Sprite One;
    public Sprite Two;
    public Sprite Three;
    public Sprite Four;
    public Sprite Five;
    public Sprite Six;

    public bool hasOne;
    public bool hasTwo;
    public bool hasThree;
    public bool hasFour;
    public bool hasFive;
    public bool hasSix;

    public bool dieOneIsActive;
    public bool dieTwoIsActive;
    public bool dieThreeIsActive;

    public UnlockNode unlockNode;

    public GameObject creditTrackerNumber;
    public GameObject multitoolTrackerNumber;
    public GameObject energyTrackerNumber;

    public int creditNumber = 0;
    public int multitoolNumber = 1;
    public int energyNumber = 1;

    public int damageNumber;

    public GameObject multitoolButton;

    public GameObject dieOneUpButton;
    public GameObject dieOneDownButton;

    public GameObject dieTwoUpButton;
    public GameObject dieTwoDownButton;

    public GameObject dieThreeUpButton;
    public GameObject dieThreeDownButton;



    //Dice are rolled and number shown on screen
    public void RollDie1()
    {
        die1.SetActive(true);
        die1Number = Random.Range(0, 7);

        if (die1Number == 1)
        {
            die1.GetComponent<Image>().sprite = One;
            
        }
        else if (die1Number == 2)
        {
            die1.GetComponent<Image>().sprite = Two;

        }
        else if (die1Number == 3)
        {
            die1.GetComponent<Image>().sprite = Three;
        }
        else if (die1Number == 4)
        {
            die1.GetComponent<Image>().sprite = Four;
        }
        else if (die1Number == 5)
        {
            die1.GetComponent<Image>().sprite = Five;
        }
        else if (die1Number == 6)
        {
            die1.GetComponent<Image>().sprite = Six;
        }

    }

    public void RollDie2()
    {
        die2.SetActive(true);
        die2Number = Random.Range(0, 7);

        if (die2Number == 1)
        {
            die2.GetComponent<Image>().sprite = One;

        }
        else if (die2Number == 2)
        {
            die2.GetComponent<Image>().sprite = Two;

        }
        else if (die2Number == 3)
        {
            die2.GetComponent<Image>().sprite = Three;
        }
        else if (die2Number == 4)
        {
            die2.GetComponent<Image>().sprite = Four;
        }
        else if (die2Number == 5)
        {
            die2.GetComponent<Image>().sprite = Five;
        }
        else if (die1Number == 6)
        {
            die2.GetComponent<Image>().sprite = Six;
        }

    }

    public void RollDie3()
    {
        die3.SetActive(true);
        die3Number = Random.Range(0, 7);

        if (die3Number == 1)
        {
            die3.GetComponent<Image>().sprite = One;

        }
        else if (die3Number == 2)
        {
            die3.GetComponent<Image>().sprite = Two;

        }
        else if (die3Number == 3)
        {
            die3.GetComponent<Image>().sprite = Three;
        }
        else if (die3Number == 4)
        {
            die3.GetComponent<Image>().sprite = Four;
        }
        else if (die3Number == 5)
        {
            die3.GetComponent<Image>().sprite = Five;
        }
        else if (die3Number == 6)
        {
            die3.GetComponent<Image>().sprite = Six;
        }
       
    }


   //track which die is clicked

    private void HasOne()
    {
        hasOne = true;
        hasTwo = false;
        hasThree = false;
        hasFour = false;
        hasFive = false;
        hasSix = false;
    }

    private void HasTwo()
    {
        hasOne = false;
        hasTwo = true;
        hasThree = false;
        hasFour = false;
        hasFive = false;
        hasSix = false;
    }

    private void HasThree()
    {
        hasOne = false;
        hasTwo = false;
        hasThree = true;
        hasFour = false;
        hasFive = false;
        hasSix = false;
    }

    private void HasFour()
    {
        hasOne = false;
        hasTwo = false;
        hasThree = false;
        hasFour = true;
        hasFive = false;
        hasSix = false;
    }

    private void HasFive()
    {
        hasOne = false;
        hasTwo = false;
        hasThree = false;
        hasFour = false;
        hasFive = true;
        hasSix = false;
    }

    private void HasSix()
    {
        hasOne = false;
        hasTwo = false;
        hasThree = false;
        hasFour = false;
        hasFive = false;
        hasSix = true;
    }

    public void HasNone()
    {
        hasOne = false;
        hasTwo = false;
        hasThree = false;
        hasFour = false;
        hasFive = false;
        hasSix = false;
        dieOneIsActive = false;
        dieTwoIsActive = false;
        dieThreeIsActive = false;
    }

    //Die is clicked

    public void Die1Clicked()
    {
        if (die1.GetComponent<Image>().sprite == One)
        {
            HasOne();
        }
        else if (die1.GetComponent<Image>().sprite == Two)
        {
            HasTwo();
        }
        else if (die1.GetComponent<Image>().sprite == Three)
        {
            HasThree();
        }
        else if (die1.GetComponent<Image>().sprite == Four)
        {
            HasFour();
        }
        else if (die1.GetComponent<Image>().sprite == Five)
        {
            HasFive();
        }
        else 
        {
            HasSix();
        }

        Die1Activate();

        unlockNode.GetComponent<UnlockNode>().NodeCheck();

    }

    public void Die2Clicked()
    {
        if (die2.GetComponent<Image>().sprite == One)
        {
            HasOne();
        }
        else if (die2.GetComponent<Image>().sprite == Two)
        {
            HasTwo();
        }
        else if (die2.GetComponent<Image>().sprite == Three)
        {
            HasThree();
        }
        else if (die2.GetComponent<Image>().sprite == Four)
        {
            HasFour();
        }
        else if (die2.GetComponent<Image>().sprite == Five)
        {
            HasFive();
        }
        else 
        {
            HasSix();
        }

        Die2Activate();

        unlockNode.GetComponent<UnlockNode>().NodeCheck();
    }

    public void Die3Clicked()
    {
        if (die3.GetComponent<Image>().sprite == One)
        {
            HasOne();
        }
        else if (die3.GetComponent<Image>().sprite == Two)
        {
            HasTwo();
        }
        else if (die3.GetComponent<Image>().sprite == Three)
        {
            HasThree();
        }
        else if (die3.GetComponent<Image>().sprite == Four)
        {
            HasFour();
        }
        else if (die3.GetComponent<Image>().sprite == Five)
        {
            HasFive();
        }
        else 
        {
            HasSix();
        }

        Die3Activate();

        unlockNode.GetComponent<UnlockNode>().NodeCheck();
    }

    void Die1Activate()
    {
        dieOneIsActive = true;
        dieTwoIsActive = false;
        dieThreeIsActive = false;
    }

    void Die2Activate()
    {
        dieOneIsActive = false;
        dieTwoIsActive = true;
        dieThreeIsActive = false;
    }

    void Die3Activate()
    {
        dieOneIsActive = false;
        dieTwoIsActive = false;
        dieThreeIsActive = true;
    }


    //disable used die

    public void Die1Disable()
    {
        die1.SetActive(false);
        dieOneIsActive = false;
        HasNone();
    }

    public void Die2Disable()
    {
        die2.SetActive(false);
        dieTwoIsActive = false;
        HasNone();
    }

    public void Die3Disable()
    {
        die3.SetActive(false);
        dieThreeIsActive = false;
        HasNone();
    }

    // Start is called before the first frame update
    void Start()
    {
        //roll dice at start of game
        RollDie1();
        RollDie2();
        RollDie3();

    }

    // Update is called once per frame
    void Update()
    {
        //track resource amounts
        creditTrackerNumber.GetComponent<TextMeshProUGUI>().text = creditNumber.ToString();
        multitoolTrackerNumber.GetComponent<TextMeshProUGUI>().text = multitoolNumber.ToString();
        energyTrackerNumber.GetComponent<TextMeshProUGUI>().text = energyNumber.ToString();

        //set multitool button active if have a multitool
        if(multitoolNumber >= 1)
        {
            multitoolButton.SetActive(true);
        }
        else
        {
            multitoolButton.SetActive(false);
        }
    }

    public void MultitoolButtonIsClicked()
    {
        dieOneUpButton.SetActive(true);
        dieOneDownButton.SetActive(true);
        dieTwoUpButton.SetActive(true);
        dieTwoDownButton.SetActive(true);
        dieThreeUpButton.SetActive(true);
        dieThreeDownButton.SetActive(true);
        multitoolNumber -= 1;
    }

    public void DieOneUpIsClicked()
    {
        if (die1Number == 1)
        {
            die1Number = 2;
            die1.GetComponent<Image>().sprite = Two;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die1Number == 2)
        {
            die1Number = 3;
            die1.GetComponent<Image>().sprite = Three;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die1Number == 3)
        {
            die1Number = 4;
            die1.GetComponent<Image>().sprite = Four;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die1Number == 4)
        {
            die1Number = 5;
            die1.GetComponent<Image>().sprite = Five;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die1Number == 5)
        {
            die1Number = 6;
            die1.GetComponent<Image>().sprite = Six;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die1Number == 6)
        {
            die1Number = 1;
            die1.GetComponent<Image>().sprite = One;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }
    }

    public void DieTwoUpIsClicked()
    {
        if (die2Number == 1)
        {
            die2Number = 2;
            die2.GetComponent<Image>().sprite = Two;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die2Number == 2)
        {
            die2Number = 3;
            die2.GetComponent<Image>().sprite = Three;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die2Number == 3)
        {
            die2Number = 4;
            die2.GetComponent<Image>().sprite = Four;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die2Number == 4)
        {
            die2Number = 5;
            die2.GetComponent<Image>().sprite = Five;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die2Number == 5)
        {
            die2Number = 6;
            die2.GetComponent<Image>().sprite = Six;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die2Number == 6)
        {
            die2Number = 1;
            die2.GetComponent<Image>().sprite = One;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }
    }

    public void DieThreeUpIsClicked()
    {
        if (die3Number == 1)
        {
            die3Number = 2;
            die3.GetComponent<Image>().sprite = Two;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die3Number == 2)
        {
            die3Number = 3;
            die3.GetComponent<Image>().sprite = Three;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die3Number == 3)
        {
            die3Number = 4;
            die3.GetComponent<Image>().sprite = Four;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die3Number == 4)
        {
            die3Number = 5;
            die3.GetComponent<Image>().sprite = Five;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die3Number == 5)
        {
            die3Number = 6;
            die3.GetComponent<Image>().sprite = Six;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die3Number == 6)
        {
            die3Number = 1;
            die3.GetComponent<Image>().sprite = One;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }
    }

    public void DieOneDownIsClicked()
    {
        if (die1Number == 1)
        {
            die1Number = 6;
            die1.GetComponent<Image>().sprite = Six;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if(die1Number == 2)
        {
            die1Number = 1;
            die1.GetComponent<Image>().sprite = One;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die1Number == 3)
        {
            die1Number = 2;
            die1.GetComponent<Image>().sprite = Two;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die1Number == 4)
        {
            die1Number = 3;
            die1.GetComponent<Image>().sprite = Three;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die1Number == 5)
        {
            die1Number = 4;
            die1.GetComponent<Image>().sprite = Four;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die1Number == 6)
        {
            die1Number = 5;
            die1.GetComponent<Image>().sprite = Five;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }
    }

    public void DieTwoDownIsClicked()
    {
        if (die2Number == 1)
        {
            die2Number = 6;
            die2.GetComponent<Image>().sprite = Six;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die2Number == 2)
        {
            die2Number = 1;
            die2.GetComponent<Image>().sprite = One;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die2Number == 3)
        {
            die2Number = 2;
            die2.GetComponent<Image>().sprite = Two;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die2Number == 4)
        {
            die2Number = 3;
            die2.GetComponent<Image>().sprite = Three;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die2Number == 5)
        {
            die2Number = 4;
            die2.GetComponent<Image>().sprite = Four;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die2Number == 6)
        {
            die2Number = 5;
            die2.GetComponent<Image>().sprite = Five;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }
    }

    public void DieThreeDownIsClicked()
    {
        if (die3Number == 1)
        {
            die3Number = 6;
            die3.GetComponent<Image>().sprite = Six;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die3Number == 2)
        {
            die3Number = 1;
            die3.GetComponent<Image>().sprite = One;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die3Number == 3)
        {
            die3Number = 2;
            die3.GetComponent<Image>().sprite = Two;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die3Number == 4)
        {
            die3Number = 3;
            die3.GetComponent<Image>().sprite = Three;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die3Number == 5)
        {
            die3Number = 4;
            die3.GetComponent<Image>().sprite = Four;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }

        else if (die3Number == 6)
        {
            die3Number = 5;
            die3.GetComponent<Image>().sprite = Five;

            dieOneUpButton.SetActive(false);
            dieOneDownButton.SetActive(false);
            dieTwoUpButton.SetActive(false);
            dieTwoDownButton.SetActive(false);
            dieThreeUpButton.SetActive(false);
            dieThreeDownButton.SetActive(false);

        }
    }

    public void AddCredit()
    {
        creditNumber += 1;
        
    }

    public void AddMultitool()
    {
        multitoolNumber += 1;
       
    }

    public void AddEnergy()
    {
        energyNumber += 1;
       
    }

}
