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

    private void HasNone()
    {
        hasOne = false;
        hasTwo = false;
        hasThree = false;
        hasFour = false;
        hasFive = false;
        hasSix = false;
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
        
    }
}
