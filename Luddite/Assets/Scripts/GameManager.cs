using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    //stuff
    public int die1Number;
    public int die2Number;
    public int die3Number;
    public int die4Number;

    public GameObject die1;
    public GameObject die2;
    public GameObject die3;
    public GameObject die4;

    public Sprite One;
    public Sprite Two;
    public Sprite Three;
    public Sprite Four;
    public Sprite Five;
    public Sprite Six;

    public Sprite[] whiteSprites;

    public bool hasOne;
    public bool hasTwo;
    public bool hasThree;
    public bool hasFour;
    public bool hasFive;
    public bool hasSix;

    public bool dieOneIsActive;
    public bool dieTwoIsActive;
    public bool dieThreeIsActive;
    public bool dieFourIsActive;

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

    public GameObject dieFourUpButton;
    public GameObject dieFourDownButton;

    public GameObject doubleCreditbutton;
    public GameObject creditButton;

    public GameObject greenCreditDie1;
    public GameObject greenCreditDie2;
    public GameObject greenCreditDie3;
    public GameObject greenCreditDie4;

    public bool reset;

    public bool die4visible;
    public bool die1isvisible;
    public bool die2isvisible;
    public bool die3isvisible;

    public int die1amount;
    public int die2amount;
    public int die3amount;
    public int die4amount;

    public GameObject damageAmountText;
    public GameObject theHackText;
    public GameObject theNedText;
    public GameObject theSwitchesText;
    public GameObject rollBonusText;
    public GameObject resourcesText;
    public GameObject theClockText;

    public int nedDamage;
    public int hackDamage;
    public int switchesDamage;
    public int rollbonusDamage;
    public int clockDamage;
    public int resourcesDamage;

    public GameObject neetle;

    public AudioSource select;

    //Dice are rolled and number shown on screen
    public void RollDie1()
    {
        die1.SetActive(true);
        die1amount = 1;
        die1isvisible = true;
        die1Number = Random.Range(1, 7);
       

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
        die2isvisible = true;
        die2amount = 1;
        die2Number = Random.Range(1, 7);
        

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
        die3isvisible = true;
        die3amount = 1;
        die3Number = Random.Range(1, 7);
        

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

    //reset everthing after re-roll

    public void ResetAfterReroll()
    {
        reset = true;
        
        reset = false;
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
        select.Play();

    

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
        select.Play();

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
        select.Play();
    }

    public void Die4Clicked()
    {
        if (die4.GetComponent<Image>().sprite == whiteSprites[0])
        {
            HasOne();
        }
        else if (die4.GetComponent<Image>().sprite == whiteSprites[1])
        {
            HasTwo();
        }
        else if (die4.GetComponent<Image>().sprite == whiteSprites[2])
        {
            HasThree();
        }
        else if (die4.GetComponent<Image>().sprite == whiteSprites[3])
        {
            HasFour();
        }
        else if (die4.GetComponent<Image>().sprite == whiteSprites[4])
        {
            HasFive();
        }
        else
        {
            HasSix();
        }

        Die4Activate();
        select.Play();
    }

    void Die1Activate()
    {
        dieOneIsActive = true;
        dieTwoIsActive = false;
        dieThreeIsActive = false;
        dieFourIsActive = false;
    }

    void Die2Activate()
    {
        dieOneIsActive = false;
        dieTwoIsActive = true;
        dieThreeIsActive = false;
        dieFourIsActive = false;
    }

    void Die3Activate()
    {
        dieOneIsActive = false;
        dieTwoIsActive = false;
        dieThreeIsActive = true;
        dieFourIsActive = false;
    }

    void Die4Activate()
    {
        dieOneIsActive = false;
        dieTwoIsActive = false;
        dieThreeIsActive = false;
        dieFourIsActive = true;
    }


    //disable used die

    public void Die1Disable()
    {
        die1.SetActive(false);
        dieOneIsActive = false;
        die1isvisible = false;
        HasNone();
       
    }

    public void Die2Disable()
    {
        die2.SetActive(false);
        dieTwoIsActive = false;
        die2isvisible = true;
        HasNone();
    
    }

    public void Die3Disable()
    {
        die3.SetActive(false);
        dieThreeIsActive = false;
        die3isvisible = true;
        HasNone();
     
    }

    public void Die4Disable()
    {
        die4.SetActive(false);
        dieFourIsActive = false;
        die4visible = false;
        dieFourUpButton.SetActive(false);
        dieFourDownButton.SetActive(false);
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

    //Double Credit Creates new Die 4

    public void DoubleCreditIsClicked()
    {
        doubleCreditbutton.SetActive(false);
        die4.SetActive(true);
        die4visible = true;
        dieFourUpButton.SetActive(true);
        die4Number = 1;
        dieFourDownButton.SetActive(true);
        creditNumber -= 2;
        die4amount = 1;
        select.Play();

    }

    public void CreditButtonIsClicked()
    {
        creditNumber -= 1;
        if (die1.activeSelf == true)
        {
            greenCreditDie1.SetActive(true);
        }

        if (die2.activeSelf == true)
        {
            greenCreditDie2.SetActive(true);
        }
        if (die3.activeSelf == true)
        {
            greenCreditDie3.SetActive(true);
        }

        if (die4visible == true)
        {
            greenCreditDie4.SetActive(true);
        }
        select.Play();
    }

    public void GreenCredDie1IsClicked()
    {
        greenCreditDie1.SetActive(false);
        greenCreditDie2.SetActive(false);
        greenCreditDie3.SetActive(false);
        greenCreditDie4.SetActive(false);

        die1amount += 1;
        select.Play();
    }

    public void GreenCredDie2IsClicked()
    {
        greenCreditDie1.SetActive(false);
        greenCreditDie2.SetActive(false);
        greenCreditDie3.SetActive(false);
        greenCreditDie4.SetActive(false);

        die2amount += 1;
        select.Play();
    }

    public void GreenCredDie3IsClicked()
    {
        greenCreditDie1.SetActive(false);
        greenCreditDie2.SetActive(false);
        greenCreditDie3.SetActive(false);
        greenCreditDie4.SetActive(false);

        die3amount += 1;
        select.Play();
    }

    public void GreenCredDie4IsClicked()
    {
        greenCreditDie1.SetActive(false);
        greenCreditDie2.SetActive(false);
        greenCreditDie3.SetActive(false);
        greenCreditDie4.SetActive(false);

        die4amount += 1;
        select.Play();
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

        //set credit button active if have a credit
        if (creditNumber >= 1)
        {
            creditButton.SetActive(true);
        }
        else
        {
            creditButton.SetActive(false);
        }

        //set Double credit button active if have a credit
        if (creditNumber >= 2 && die4visible == false)
        {
            doubleCreditbutton.SetActive(true);
        }
        else
        {
            doubleCreditbutton.SetActive(false);
        }
    }

    public void MultitoolButtonIsClicked()
    {
        if (die1.activeSelf == true)
        {
            dieOneUpButton.SetActive(true);
            dieOneDownButton.SetActive(true);
        }
        if (die2.activeSelf == true)
        {
            dieTwoUpButton.SetActive(true);
            dieTwoDownButton.SetActive(true);
        }
        if (die3.activeSelf == true)
        {
            dieThreeUpButton.SetActive(true);
            dieThreeDownButton.SetActive(true);
        }
        
        multitoolNumber -= 1;
        select.Play();
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
        select.Play();
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
        select.Play();
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
        select.Play();
    }

    public void DieFourUpIsClicked()
    {
        if (die4Number == 1)
        {
            die4Number = 2;
            die4.GetComponent<Image>().sprite = whiteSprites[1];

        }

        else if (die4Number == 2)
        {
            die4Number = 3;
            die4.GetComponent<Image>().sprite = whiteSprites[2];
        }

        else if (die4Number == 3)
        {
            die4Number = 4;
            die4.GetComponent<Image>().sprite = whiteSprites[3];


        }

        else if (die4Number == 4)
        {
            die4Number = 5;
            die4.GetComponent<Image>().sprite = whiteSprites[4];

        }

        else if (die4Number == 5)
        {
            die4Number = 6;
            die4.GetComponent<Image>().sprite = whiteSprites[5];

        }

        else if (die4Number == 6)
        {
            die4Number = 1;
            die4.GetComponent<Image>().sprite = whiteSprites[0];

        }
        select.Play();
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
        select.Play();
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
        select.Play();
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
        select.Play();
    }

    public void DieFourDownIsClicked()
    {
        if (die4Number == 1)
        {
            die4Number = 6;
            die4.GetComponent<Image>().sprite = whiteSprites[5];

        }

        else if (die4Number == 2)
        {
            die4Number = 1;
            die4.GetComponent<Image>().sprite = whiteSprites[0];

        }

        else if (die4Number == 3)
        {
            die4Number = 2;
            die4.GetComponent<Image>().sprite = whiteSprites[1];

        }

        else if (die4Number == 4)
        {
            die4Number = 3;
            die4.GetComponent<Image>().sprite = whiteSprites[2];

        }

        else if (die4Number == 5)
        {
            die4Number = 4;
            die4.GetComponent<Image>().sprite = whiteSprites[3];

        }

        else if (die4Number == 6)
        {
            die4Number = 5;
            die4.GetComponent<Image>().sprite = whiteSprites[4];

        }
        select.Play();
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

    public void ResetDieUpandDownButtonsOnReRoll()
    {
        dieOneUpButton.SetActive(false);
        dieOneDownButton.SetActive(false);
        dieTwoUpButton.SetActive(false);
        dieTwoDownButton.SetActive(false);
        dieThreeUpButton.SetActive(false);
        dieThreeDownButton.SetActive(false);
    }

    public void EndGameScore()
    {
        neetle.GetComponent<NeetleBehaviour>().CheckIfNeetleatExit();
        if (neetle.GetComponent<NeetleBehaviour>().neetleInFinalLocation == true)
        {
            Debug.Log("in right location");
            //add resource damage to total damage

            damageNumber = damageNumber + multitoolNumber;
            damageNumber = damageNumber + energyNumber;
            damageNumber = damageNumber + (creditNumber * 2);

            //calculate resource damage separately

            resourcesDamage = multitoolNumber + energyNumber + (creditNumber * 2);


            //display damage score

            theNedText.GetComponent<TextMeshProUGUI>().text = nedDamage.ToString();
            theHackText.GetComponent<TextMeshProUGUI>().text = hackDamage.ToString();
            theSwitchesText.GetComponent<TextMeshProUGUI>().text = switchesDamage.ToString();
            rollBonusText.GetComponent<TextMeshProUGUI>().text = rollbonusDamage.ToString();
            theClockText.GetComponent<TextMeshProUGUI>().text = clockDamage.ToString();
            resourcesText.GetComponent<TextMeshProUGUI>().text = resourcesDamage.ToString();
            damageAmountText.GetComponent<TextMeshProUGUI>().text = damageNumber.ToString();
        }
        else
        {
            Debug.Log("in wrong location");
            damageNumber = 0;
            nedDamage = 0;
            hackDamage = 0;
            switchesDamage = 0;
            rollbonusDamage = 0;
            resourcesDamage = 0;
            damageNumber = 0;

            theNedText.GetComponent<TextMeshProUGUI>().text = nedDamage.ToString();
            theHackText.GetComponent<TextMeshProUGUI>().text = hackDamage.ToString();
            theSwitchesText.GetComponent<TextMeshProUGUI>().text = switchesDamage.ToString();
            rollBonusText.GetComponent<TextMeshProUGUI>().text = rollbonusDamage.ToString();
            theClockText.GetComponent<TextMeshProUGUI>().text = clockDamage.ToString();
            resourcesText.GetComponent<TextMeshProUGUI>().text = resourcesDamage.ToString();
            damageAmountText.GetComponent<TextMeshProUGUI>().text = damageNumber.ToString();
        }
        
    }

}
