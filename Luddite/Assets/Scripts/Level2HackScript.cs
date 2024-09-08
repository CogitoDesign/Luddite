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

    public bool hasTool2;


    //Tool 3 items

    public bool hasTool3;


    //Tool 4 items

    public bool hasTool4;


    //Tool 5 items

    public bool hasTool5;


    //Tool 6 items

    public bool hasTool6;

    //Double Credit Items

    //8 Damage 1 items


    //8 Damage 2 items




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

    


    // Start is called before the first frame update
    void Start()
    {
        numberOfToolOneBoxesUsed = 0;
        toolOneCurrentValue = 0;
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
            

        }
        else if (gameManager.hasTwo)
        {
            currentSelectedDieNumber = 2;
            Tool1Box1Check();
            
        }
        else if (gameManager.hasThree)
        {
            currentSelectedDieNumber = 3;
            Tool1Box1Check();
           
        }
        else if (gameManager.hasFour)
        {
            currentSelectedDieNumber = 4;
            Tool1Box1Check();
            
        }
        else if (gameManager.hasFive)
        {
            currentSelectedDieNumber = 5;
            Tool1Box1Check();
           
        }
        else if (gameManager.hasSix)
        {
            currentSelectedDieNumber = 6;
            Tool1Box1Check();
            
        }
        else
        {
            tool1Box1.SetActive(false);
            
            //add all other buttons here in the same way
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

        /*
        if (buttonThree3isDone == true && buttonSix2isDone == true && buttonOne1isDone == true && buttonFive3isDone == true)
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

        if (buttonOne1isDone == true && buttonSix3isDone == true && buttonTwo2isDone == true && buttonThree4isDone == true)
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

        if (buttonFive4isDone == true && buttonSix5isDone == true && buttonOne4isDone == true && buttonFive6isDone == true)
        {
            if (neetleBehaviour.GetComponent<NeetleBehaviour>().tool4done == false)
            {
                if (bonuses[3] == false)
                {
                    bonuses[3] = true;
                    hasTool4 = true;
                    tool4.SetActive(false);
                    tool4BLUE.SetActive(true);
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
            }
        }

        if (buttonFive5isDone == true && buttonTwo4isDone == true && buttonSix7isDone == true && buttonTwo5isDone == true)
        {
            if (neetleBehaviour.GetComponent<NeetleBehaviour>().tool5done == false)
            {
                if (bonuses[4] == false)
                {
                    bonuses[4] = true;
                    hasTool5 = true;
                    tool5.SetActive(false);
                    tool5BLUE.SetActive(true);
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
            }
        }
        if (buttonOne3isDone == true && buttonOne4isDone == true && buttonSix6isDone == true && buttonFour5isDone == true && buttonSix7isDone == true)
        {
            if (neetleBehaviour.GetComponent<NeetleBehaviour>().tool6done == false)
            {
                if (bonuses[5] == false)
                {
                    bonuses[5] = true;
                    hasTool6 = true;
                    tool6.SetActive(false);
                    tool6BLUE.SetActive(true);
                    StartCoroutine(playBonusWithDelay(0.5f));
                }
            }
        }

        if (buttonSix4isDone == true && buttonOne2isDone == true)
        {
            if (bonuses[6] == false)
            {
                bonuses[6] = true;
                gameManager.AddCredit();
                StartCoroutine(playBonusWithDelay(0.5f));
            }
        }

        if (buttonFour2isDone == true && buttonThree1isDone == true && buttonFive1isDone == true && buttonTwo1isDone == true && buttonThree2isDone == true && buttonFive2isDone == true)
        {
            if (bonuses[7] == false)
            {
                bonuses[7] = true;
                damageBonus1 = true;

                increaseDamage();
                StartCoroutine(playBonusWithDelay(0.5f));
            }


        }
        if (buttonTwo3isDone == true && buttonFive4isDone == true && buttonThree4isDone == true && buttonFour4isDone == true && buttonFive5isDone == true && buttonOne2isDone == true)
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

        
    }

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
        




        if (tool1Test1 == false)
        {
            canAddDieToToolOne = false;
        }
        else
        {
            canAddDieToToolOne = true;
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

    IEnumerator playBonusWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        bonusSFX.Play();
    }


}
