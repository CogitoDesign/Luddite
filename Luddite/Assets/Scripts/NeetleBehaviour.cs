using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NeetleBehaviour : MonoBehaviour
{
    [SerializeField] private int currentXAxis;
    [SerializeField] private int currentYAxis;

    public GameObject neetle;

    public float speed;

    private GameObject targetLocation;

    public Sprite[] numberSprites;
    public GameObject[] mapMarkers;

    private int spriteNumber;

    public GameManager gameManager;

    public GameObject dieMoveIcon;

    public GameObject doubleEnergyButton;
    public GameObject energyButton;

    public GameObject rightButton;
    public GameObject leftButton;
    public GameObject upButton;
    public GameObject downButton;

    public int dieMoveNumber;

    public UnlockNode unlockNode;

    public GameObject nodes;

    public GameObject switchPanel;

    private GameObject leftLocation;
    private bool leftLocationIsOpen;

    private GameObject rightLocation;
    private bool rightLocationIsOpen;

    private GameObject upLocation;
    private bool upLocationIsOpen;

    private GameObject downLocation;
    private bool downLocationIsOpen;

    private bool x1y2;
    private bool x1y3;
    private bool x1y4;

    private bool x2y1;
    private bool x2y2;
    private bool x2y3;
    private bool x2y4;

    private bool x3y1;
    private bool x3y2;
    private bool x3y3;
    private bool x3y4;

    private bool x4y1;
    private bool x4y2;
    private bool x4y3;
    private bool x4y4;

    private bool x5y1;
    private bool x5y2;
    private bool x5y3;
    private bool x5y4;

    private bool x6y1;
    private bool x6y2;
    private bool x6y3;
    private bool x6y4;

    public GameObject leftDEIcon;
    public GameObject rightDEIcon;
    public GameObject upDEIcon;
    public GameObject downDEIcon;

    private bool bonusMultitool;
    private bool bonusCredit1;
    private bool bonusCredit2;
    private bool bonusEnergy;
    private bool bonusMultitools;

    public GameObject bonusMultitoolsNode;
    public GameObject bonusMultitoolNode;
    public GameObject bonusCreditNode1;
    public GameObject bonusCreditNode2;
    public GameObject bonusEnergyNode;

    public Material green;

    private bool tool1done;
    private bool tool2done;
    private bool tool3done;
    private bool tool4done;
    private bool tool5done;
    private bool tool6done;

    public GameObject screensAppear;

    public GameObject[] toolNodes;

    public GameObject hacScreen;

    public bool neetleInFinalLocation;



    public void CheckIfNeetleatExit()
    {
        if (currentXAxis == 6 && currentYAxis == 4)
        {
            neetleInFinalLocation = true;
        }
    }

    //Show Move screen when click Neetle

    private void OnMouseDown()
    {
        screensAppear.GetComponent<ScreensAppear>().MoveOptionsMenuIsOn();
    }


    //add the active die to the movepad make diemovenumber the same.

    public void AddDieButtonIsClicked()
    {
        if(gameManager.GetComponent<GameManager>().hasOne == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[0];
            dieMoveNumber = 1;

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

        else if (gameManager.GetComponent<GameManager>().hasTwo == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[1];
            dieMoveNumber = 2;

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

        else if (gameManager.GetComponent<GameManager>().hasThree == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[2];
            dieMoveNumber = 3;



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
        else if (gameManager.GetComponent<GameManager>().hasFour == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[3];
            dieMoveNumber = 4;



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
        else if (gameManager.GetComponent<GameManager>().hasFive == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[4];
            dieMoveNumber = 5;



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
        else if (gameManager.GetComponent<GameManager>().hasSix == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[5];
            dieMoveNumber = 6;
            
            energyButton.SetActive(false);

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

    }

    //adds three movement when energy button is clicked

    public void EnergyButtonIsclicked()
    {
        gameManager.energyNumber -= 1;
        if (dieMoveNumber <= 3)
        {
            dieMoveNumber += 3;
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[dieMoveNumber -1];
        }
        else if (dieMoveNumber >= 4)
        {
            dieMoveNumber = 6;
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[5];
        }
        
    }

    //allows movement anywhere when double energy button is clicked

    public void DoubleEnergyButtonIsClicked()
    {
        gameManager.energyNumber -= 2;

        if (currentYAxis == 1)
        {
            leftDEIcon.SetActive(false);
        }
        else
        {
            leftDEIcon.SetActive(true);
        }

        if (currentYAxis == 4)
        {
            rightDEIcon.SetActive(false);
        }
        else
        {
            rightDEIcon.SetActive(true);
        }

        if (currentXAxis == 1)
        {
            upDEIcon.SetActive(false);
        }
        else
        {
            upDEIcon.SetActive(true);
        }
        if (currentXAxis == 6)
        {
            downDEIcon.SetActive(false);
        }
        else
        {
            downDEIcon.SetActive(true);
        }

    }

    public void LeftDEIsClicked()
    {
        currentYAxis -= 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
        leftDEIcon.SetActive(false);
        rightDEIcon.SetActive(false);
        upDEIcon.SetActive(false);
        downDEIcon.SetActive(false);
    }

    public void RightDEIsClicked()
    {
        currentYAxis += 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
        leftDEIcon.SetActive(false);
        rightDEIcon.SetActive(false);
        upDEIcon.SetActive(false);
        downDEIcon.SetActive(false);
    }

    public void UpDEIsClicked()
    {
        currentXAxis -= 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
        leftDEIcon.SetActive(false);
        rightDEIcon.SetActive(false);
        upDEIcon.SetActive(false);
        downDEIcon.SetActive(false);
    }

    public void DownDEIsClicked()
    {
        currentXAxis += 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
        leftDEIcon.SetActive(false);
        rightDEIcon.SetActive(false);
        upDEIcon.SetActive(false);
        downDEIcon.SetActive(false);
    }

    //move neetle when arrow is clicked

    public void RightButtonIsClicked()
    {
        currentYAxis += 1;
        FindTargetLocation();
      
        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
        dieMoveNumber -= 1;
        ChangeDieSprite();
    }

    public void LeftButtonIsClicked()
    {
        currentYAxis -= 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
        dieMoveNumber -= 1;
        ChangeDieSprite();
    }

    public void UpButtonIsClicked()
    {
        currentXAxis -= 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
        dieMoveNumber -= 1;
        ChangeDieSprite();
    }

    public void DownButtonIsClicked()
    {
        currentXAxis += 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
        dieMoveNumber -= 1;
        ChangeDieSprite();
    }

    //coroutine to move neetle

    IEnumerator MoveToTarget(GameObject neetle, GameObject targetLocation, float speedTranslation)
    {
        while (gameObject.transform.position != targetLocation.transform.position)
        {
            neetle.transform.position = Vector3.MoveTowards(neetle.transform.position, targetLocation.transform.position, speed * Time.deltaTime);
            yield return null;
        }
    }

    private void ChangeDieSprite()
    {
        if (dieMoveNumber >= 1)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[dieMoveNumber - 1];
        }
        else
        {
            dieMoveIcon.GetComponent<Image>().sprite = null;
        }
    }

    //check the locations orthogonally to neetle and allow movement if the die node is unlocked and switches have correct allignment

    private void CheckLeftLocationIsOpen()
    {
        if (currentXAxis == 1 && currentYAxis == 1)
        {
            leftLocation = null;
            leftLocationIsOpen = false;
        }
        else if (currentXAxis == 1 && currentYAxis == 2)
        {
            leftLocation = mapMarkers[0];
            leftLocationIsOpen = true;
        }
        else if (currentXAxis == 1 && currentYAxis == 3)
        {
            leftLocation = mapMarkers[1];

            if (unlockNode.DieSixnode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn))
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 1 && currentYAxis == 4)
        {
            leftLocation = mapMarkers[2];
            if (unlockNode.DieOnenode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 1)
        {
            leftLocation = null;
            leftLocationIsOpen = false;
        }
        else if (currentXAxis == 2 && currentYAxis == 2)
        {
            leftLocation = mapMarkers[4];
            if (unlockNode.DieFivenode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 3)
        {
            leftLocation = mapMarkers[5];
            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 4)
        {
            leftLocation = mapMarkers[6];

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 1)
        {
            leftLocation = null;
            leftLocationIsOpen = false;
        }
        else if (currentXAxis == 3 && currentYAxis == 2)
        {
            leftLocation = mapMarkers[8];
            if (unlockNode.DieTwonode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn))
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 3)
        {
            leftLocation = mapMarkers[9];
            if (unlockNode.DieSixnode2IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 4)
        {
            leftLocation = mapMarkers[10];

            if (unlockNode.DieTwonode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn))
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 1)
        {
            leftLocation = null;
            leftLocationIsOpen = false;
        }
        else if (currentXAxis == 4 && currentYAxis == 2)
        {
            leftLocation = mapMarkers[12];
            if (unlockNode.DieThreenode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 3)
        {
            leftLocation = mapMarkers[13];
            if (!switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 4)
        {
            leftLocation = mapMarkers[14];
            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 1)
        {
            leftLocation = null;
            leftLocationIsOpen = false;
        }
        else if (currentXAxis == 5 && currentYAxis == 2)
        {
            leftLocation = mapMarkers[16];
            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 3)
        {
            leftLocation = mapMarkers[17];
            if (unlockNode.DieOnenode2IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 4)
        {
            leftLocation = mapMarkers[18];
            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 1)
        {
            leftLocation = null;
            leftLocationIsOpen = false;
        }
        else if (currentXAxis == 6 && currentYAxis == 2)
        {
            leftLocation = mapMarkers[20];
            if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 3)
        {
            leftLocation = mapMarkers[21];

            if (unlockNode.DieFournode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 4)
        {
            leftLocation = mapMarkers[18];
            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                leftLocationIsOpen = true;
            }
            else
            {
                leftLocationIsOpen = false;
            }
        }
    }

    private void CheckRightLocationIsOpen()
    {
        if (currentXAxis == 1 && currentYAxis == 1)
        {
            rightLocation = mapMarkers[1];

            if (x1y2 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 1 && currentYAxis == 2)
        {
            rightLocation = mapMarkers[2];
            if (x1y3 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 1 && currentYAxis == 3)
        {
            rightLocation = mapMarkers[3];

            if (x1y4 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 1 && currentYAxis == 4)
        {
            rightLocation = null;
            rightLocationIsOpen = false;
        }
        else if (currentXAxis == 2 && currentYAxis == 1)
        {
            rightLocation = mapMarkers[5];

            if (x2y2 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 2)
        {
            rightLocation = mapMarkers[6];
            if (x2y3 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 3)
        {
            rightLocation = mapMarkers[7];
            if (x2y4 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 4)
        {
            rightLocation = null;
            rightLocationIsOpen = false;
        }
        else if (currentXAxis == 3 && currentYAxis == 1)
        {
            rightLocation = mapMarkers[9];

            if (x3y2 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 2)
        {
            rightLocation = mapMarkers[10];
            if (x3y3 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 3)
        {
            rightLocation = mapMarkers[11];
            if (x3y4 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 4)
        {
            rightLocation = null;
            rightLocationIsOpen = false;
        }
        else if (currentXAxis == 4 && currentYAxis == 1)
        {
            rightLocation = mapMarkers[13];

            if (x4y2 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 2)
        {
            rightLocation = mapMarkers[14];
            if (x4y3 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 3)
        {
            rightLocation = mapMarkers[15];
            if (x4y4 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 4)
        {
            rightLocation = null;
            rightLocationIsOpen = false;
        }
        else if (currentXAxis == 5 && currentYAxis == 1)
        {
            rightLocation = mapMarkers[17];

            if (x5y2 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 2)
        {
            rightLocation = mapMarkers[18];
            if (x5y3 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 3)
        {
            rightLocation = mapMarkers[19];
            if (x5y4 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 4)
        {
            rightLocation = null;
            rightLocationIsOpen = false;
        }
        else if (currentXAxis == 6 && currentYAxis == 1)
        {
            rightLocation = mapMarkers[21];

            if (x6y2 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 2)
        {
            rightLocation = mapMarkers[22];
            if (x6y3 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 3)
        {
            rightLocation = mapMarkers[23];

            if (x6y4 == true)
            {
                rightLocationIsOpen = true;
            }
            else
            {
                rightLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 4)
        {
            rightLocation = null;
            rightLocationIsOpen = false;
        }
    }

    private void CheckUpLocationIsOpen()
    {
        if (currentXAxis == 1 && currentYAxis == 1)
        {
            upLocation = null;
            upLocationIsOpen = false;
        }
        else if (currentXAxis == 1 && currentYAxis == 2)
        {
            upLocation = null;
            upLocationIsOpen = false;
        }
        else if (currentXAxis == 1 && currentYAxis == 3)
        {
            upLocation = null;
            upLocationIsOpen = false;
        }
        else if (currentXAxis == 1 && currentYAxis == 4)
        {
            upLocation = null;
            upLocationIsOpen = false;
        }
        else if (currentXAxis == 2 && currentYAxis == 1)
        {
            upLocation = mapMarkers[0];
            upLocationIsOpen = true;
        }
        else if (currentXAxis == 2 && currentYAxis == 2)
        {
            upLocation = mapMarkers[1];

            if (x1y2 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 3)
        {
            upLocation = mapMarkers[2];
            if (x1y3 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 4)
        {
            upLocation = mapMarkers[3];
            if (x1y4 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 1)
        {
            upLocation = mapMarkers[4];

            if (x2y1 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 2)
        {
            upLocation = mapMarkers[5];
            if (x2y2 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 3)
        {
            upLocation = mapMarkers[6];
            if (x2y3 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 4)
        {
            upLocation = mapMarkers[7];
            if (x2y4 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 1)
        {
            upLocation = mapMarkers[8];

            if (x3y1 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 2)
        {
            upLocation = mapMarkers[9];
            if (x3y2 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 3)
        {
            upLocation = mapMarkers[10];
            if (x3y3 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 4)
        {
            upLocation = mapMarkers[11];
            if (x3y4 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 1)
        {
            upLocation = mapMarkers[12];

            if (x4y1 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 2)
        {
            upLocation = mapMarkers[13];
            if (x4y2 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 3)
        {
            upLocation = mapMarkers[14];
            if (x4y3 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 4)
        {
            upLocation = mapMarkers[15];
            if (x4y4 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 1)
        {
            upLocation = mapMarkers[16];

            if (x5y1 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 2)
        {
            upLocation = mapMarkers[17];
            if (x5y2 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 3)
        {
            upLocation = mapMarkers[18];

            if (x5y3 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 4)
        {
            upLocation = mapMarkers[19];
            if (x5y4 == true)
            {
                upLocationIsOpen = true;
            }
            else
            {
                upLocationIsOpen = false;
            }
        }
    }

    private void CheckDownLocationIsOpen()
    {
        if (currentXAxis == 1 && currentYAxis == 1)
        {
            downLocation = mapMarkers[4];
            if (x2y1 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 1 && currentYAxis == 2)
        {
            downLocation = mapMarkers[5];
            if (x2y2 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 1 && currentYAxis == 3)
        {
            downLocation = mapMarkers[6];
            if (x2y3 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 1 && currentYAxis == 4)
        {
            downLocation = mapMarkers[7];
            if (x2y4 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 1)
        {
            downLocation = mapMarkers[8];
            if (x3y1 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 2)
        {
            downLocation = mapMarkers[9];

            if (x3y2 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 3)
        {
            downLocation = mapMarkers[10];
            if (x3y3 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 2 && currentYAxis == 4)
        {
            downLocation = mapMarkers[11];
            if (x3y4 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 1)
        {
            downLocation = mapMarkers[12];

            if (x4y1 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 2)
        {
            downLocation = mapMarkers[13];
            if (x4y2 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 3)
        {
            downLocation = mapMarkers[14];
            if (x4y3 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 3 && currentYAxis == 4)
        {
            downLocation = mapMarkers[15];
            if (x4y4 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 1)
        {
            downLocation = mapMarkers[16];

            if (x5y1 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 2)
        {
            downLocation = mapMarkers[17];
            if (x5y2 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 3)
        {
            downLocation = mapMarkers[18];
            if (x5y3 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 4 && currentYAxis == 4)
        {
            downLocation = mapMarkers[19];
            if (x5y4 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 1)
        {
            downLocation = mapMarkers[20];

            if (x6y1 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 2)
        {
            downLocation = mapMarkers[21];
            if (x6y2 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 3)
        {
            downLocation = mapMarkers[22];
            if (x6y3 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 5 && currentYAxis == 4)
        {
            downLocation = mapMarkers[23];
            if (x6y4 == true)
            {
                downLocationIsOpen = true;
            }
            else
            {
                downLocationIsOpen = false;
            }
        }
        else if (currentXAxis == 6 && currentYAxis == 1)
        {
            downLocation = null;
            downLocationIsOpen = false;
        }
        else if (currentXAxis == 6 && currentYAxis == 2)
        {
            downLocation = null;
            downLocationIsOpen = false;
        }
        else if (currentXAxis == 6 && currentYAxis == 3)
        {
            downLocation = null;
            downLocationIsOpen = false;
        }
        else if (currentXAxis == 6 && currentYAxis == 4)
        {
            downLocation = null;
            downLocationIsOpen = false;
        }
    }

    private void FindTargetLocation()
    {
        if(currentXAxis == 1 && currentYAxis == 1)
        {
            targetLocation = mapMarkers[0];
        }
        else if (currentXAxis == 1 && currentYAxis == 2)
        {
            targetLocation = mapMarkers[1];
        }
        else if (currentXAxis == 1 && currentYAxis == 3)
        {
            targetLocation = mapMarkers[2];
        }
        else if (currentXAxis == 1 && currentYAxis == 4)
        {
            targetLocation = mapMarkers[3];
        }
        else if (currentXAxis == 2 && currentYAxis == 1)
        {
            targetLocation = mapMarkers[4];
        }
        else if (currentXAxis == 2 && currentYAxis == 2)
        {
            targetLocation = mapMarkers[5];
        }
        else if (currentXAxis == 2 && currentYAxis == 3)
        {
            targetLocation = mapMarkers[6];
        }
        else if (currentXAxis == 2 && currentYAxis == 4)
        {
            targetLocation = mapMarkers[7];
        }
        else if (currentXAxis == 3 && currentYAxis == 1)
        {
            targetLocation = mapMarkers[8];
        }
        else if (currentXAxis == 3 && currentYAxis == 2)
        {
            targetLocation = mapMarkers[9];
        }
        else if (currentXAxis == 3 && currentYAxis == 3)
        {
            targetLocation = mapMarkers[10];
        }
        else if (currentXAxis == 3 && currentYAxis == 4)
        {
            targetLocation = mapMarkers[11];
        }
        else if (currentXAxis == 4 && currentYAxis == 1)
        {
            targetLocation = mapMarkers[12];
        }
        else if (currentXAxis == 4 && currentYAxis == 2)
        {
            targetLocation = mapMarkers[13];
        }
        else if (currentXAxis == 4 && currentYAxis == 3)
        {
            targetLocation = mapMarkers[14];
        }
        else if (currentXAxis == 4 && currentYAxis == 4)
        {
            targetLocation = mapMarkers[15];
        }
        else if (currentXAxis == 5 && currentYAxis == 1)
        {
            targetLocation = mapMarkers[16];
        }
        else if (currentXAxis == 5 && currentYAxis == 2)
        {
            targetLocation = mapMarkers[17];
        }
        else if (currentXAxis == 5 && currentYAxis == 3)
        {
            targetLocation = mapMarkers[18];
        }
        else if (currentXAxis == 5 && currentYAxis == 4)
        {
            targetLocation = mapMarkers[19];
        }
        else if (currentXAxis == 6 && currentYAxis == 1)
        {
            targetLocation = mapMarkers[20];
        }
        else if (currentXAxis == 6 && currentYAxis == 2)
        {
            targetLocation = mapMarkers[21];
        }
        else if (currentXAxis == 6 && currentYAxis == 3)
        {
            targetLocation = mapMarkers[22];
        }
        else if (currentXAxis == 6 && currentYAxis == 4)
        {
            targetLocation = mapMarkers[23];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentXAxis = 1;
        currentYAxis = 1;
    }

    // Update is called once per frame
    void Update()
    {
        CheckLeftLocationIsOpen();
        CheckRightLocationIsOpen();
        CheckUpLocationIsOpen();
        CheckDownLocationIsOpen();

        //turn on energy buttons only when have required energy

        if (gameManager.energyNumber >= 1)
        {
            energyButton.SetActive(true);
        }
        else
        {
            energyButton.SetActive(false);
        }

        if (gameManager.energyNumber >= 2)
        {
            doubleEnergyButton.SetActive(true);
        }
        else
        {
            doubleEnergyButton.SetActive(false);
        }

        //turn off move buttons when not usable
        if(currentYAxis == 4)
        {
            rightButton.SetActive(false);
        }
        else if (dieMoveNumber >= 1 && rightLocationIsOpen == true)
        {
            rightButton.SetActive(true);
        }
        else
        {
            rightButton.SetActive(false);
        }

        if (currentYAxis == 1)
        {
            leftButton.SetActive(false);
        }
        else if (dieMoveNumber >= 1 && leftLocationIsOpen == true)
        {
            leftButton.SetActive(true);
        }
        else
        {
            leftButton.SetActive(false);
        }

        if (currentXAxis == 1)
        {
            upButton.SetActive(false);
        }
        else if (dieMoveNumber >= 1 && upLocationIsOpen == true)
        {
            upButton.SetActive(true);
        }
        else
        {
            upButton.SetActive(false);
        }

        if (currentXAxis == 6)
        {
            downButton.SetActive(false);
        }
        else if (dieMoveNumber >= 1 && downLocationIsOpen == true)
        {
            downButton.SetActive(true);
        }
        else
        {
            downButton.SetActive(false);
        }

        //check if nodes are open by checking switch config and node gates

        if (unlockNode.DieSixnode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn))
        {
            x1y2 = true;
        }

        if (unlockNode.DieOnenode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
        {
            x1y3 = true;
        }

        if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
        {
            x1y4 = true;
        }

        if (unlockNode.DieFivenode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
        {
            x2y1 = true;
        }

        if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
        {
            x2y2 = true;
        }

        if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
        {
            x2y3 = true;
        }

        if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
        {
            x2y4 = true;
        }

        if (unlockNode.DieTwonode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn))
        {
            x3y1 = true;
        }

        if (unlockNode.DieSixnode2IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
        {
            x3y2 = true;
        }

        if (unlockNode.DieTwonode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
        {
            x3y3 = true;
        }

        if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
        {
            x3y4 = true;
        }

        if (unlockNode.DieThreenode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
        {
            x4y1 = true;
        }

        if (!switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
        {
            x4y2 = true;
        }

        if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
        {
            x4y3 = true;
        }

        if (unlockNode.DieFivenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
        {
            x4y4 = true;
        }

        if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
        {
            x5y1 = true;
        }

        if (unlockNode.DieOnenode2IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
        {
            x5y2 = true;
        }

        if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
        {
            x5y3 = true;
        }

        if (unlockNode.DieTwonode3IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
        {
            x5y4 = true;
        }

        if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
        {
            x6y1 = true;
        }

        if (unlockNode.DieFournode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
        {
            x6y2 = true;
        }

        if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
        {
            x6y3 = true;
        }

        if (!switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
        {
            x6y4 = true;
        }

        //Check if neetle has entered a bonus location and give bonus, turn node green then stop allowing bonus

        if ((currentXAxis == 6 && currentYAxis == 3) && bonusMultitools == false)
        {
            gameManager.multitoolNumber += 2;
            bonusMultitools = true;
            bonusMultitoolsNode.GetComponent<MeshRenderer>().material = green;
        }

        if ((currentXAxis == 4 && currentYAxis == 3) && bonusEnergy == false)
        {
            gameManager.energyNumber += 1;
            bonusEnergy = true;
            bonusEnergyNode.GetComponent<MeshRenderer>().material = green;
        }

        if ((currentXAxis == 2 && currentYAxis == 4) && bonusCredit1 == false)
        {
            gameManager.creditNumber += 1;
            bonusCredit1 = true;
            bonusCreditNode1.GetComponent<MeshRenderer>().material = green;
        }

        if ((currentXAxis == 5 && currentYAxis == 1) && bonusCredit2 == false)
        {
            gameManager.creditNumber += 1;
            bonusCredit2 = true;
            bonusCreditNode2.GetComponent<MeshRenderer>().material = green;
        }

        if ((currentXAxis == 2 && currentYAxis == 3) && bonusMultitool == false)
        {
            gameManager.multitoolNumber += 1;
            bonusMultitool = true;
            bonusMultitoolNode.GetComponent<MeshRenderer>().material = green;
        }

        //Check if have tool when entering tool node and activate node if you do

       if ((currentXAxis == 1 && currentYAxis == 4) && (hacScreen.GetComponent<HackBehaviour>().hasTool2 == true && tool2done == false))
       {
            tool2done = true;
            toolNodes[1].GetComponent<MeshRenderer>().material = green;
            gameManager.damageNumber += 12;
            gameManager.nedDamage += 12;
            hacScreen.GetComponent<HackBehaviour>().hasTool2 = false;
       }

        if ((currentXAxis == 2 && currentYAxis == 2) && (hacScreen.GetComponent<HackBehaviour>().hasTool1 == true && tool1done == false))
        {
            tool1done = true;
            toolNodes[0].GetComponent<MeshRenderer>().material = green;
            gameManager.damageNumber += 9;
            gameManager.nedDamage += 9;
            hacScreen.GetComponent<HackBehaviour>().hasTool1 = false;
        }

        if ((currentXAxis == 3 && currentYAxis == 4) && (hacScreen.GetComponent<HackBehaviour>().hasTool4 == true && tool4done == false))
        {
            tool4done = true;
            toolNodes[3].GetComponent<MeshRenderer>().material = green;
            gameManager.damageNumber += 15;
            gameManager.nedDamage += 15;
            hacScreen.GetComponent<HackBehaviour>().hasTool4 = false;
        }

        if ((currentXAxis == 4 && currentYAxis == 2) && (hacScreen.GetComponent<HackBehaviour>().hasTool5 == true && tool5done == false))
        {
            tool5done = true;
            toolNodes[4].GetComponent<MeshRenderer>().material = green;
            gameManager.damageNumber += 15;
            gameManager.nedDamage += 15;
            hacScreen.GetComponent<HackBehaviour>().hasTool5 = false;
        }

        if ((currentXAxis == 5 && currentYAxis == 3) && (hacScreen.GetComponent<HackBehaviour>().hasTool3 == true && tool3done == false))
        {
            tool3done = true;
            toolNodes[2].GetComponent<MeshRenderer>().material = green;
            gameManager.damageNumber += 17;
            gameManager.nedDamage += 17;
            hacScreen.GetComponent<HackBehaviour>().hasTool3 = false;
        }

        if ((currentXAxis == 6 && currentYAxis == 1) && (hacScreen.GetComponent<HackBehaviour>().hasTool6 == true && tool6done == false))
        {
            tool6done = true;
            toolNodes[5].GetComponent<MeshRenderer>().material = green;
            gameManager.damageNumber += 20;
            gameManager.nedDamage += 20;
            hacScreen.GetComponent<HackBehaviour>().hasTool6 = false;
        }

    }
}
