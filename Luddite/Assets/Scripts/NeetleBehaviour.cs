using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
using System.Drawing;

public class NeetleBehaviour : MonoBehaviour
{
    [SerializeField] private int currentXAxis;
    [SerializeField] private int currentYAxis;

    public GameObject neetle;

    public float speed;
    public float rotationSpeed;



    public Sprite[] numberSprites;
    public GameObject[] mapMarkers;

    private GameObject targetLocation;

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

    public EnergyNode1 energyNode1;
    public EnergyNode2 energyNode2;
    public EnergyNode3 energyNode3;

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

    private bool x1y1;
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

    public GameObject[] energyNodes;

    public Material green;

    public bool tool1done;
    public bool tool2done;
    public bool tool3done;
    public bool tool4done;
    public bool tool5done;
    public bool tool6done;

    public GameObject screensAppear;

    public GameObject[] toolNodes;

    public GameObject hacScreen;

    public bool neetleInFinalLocation;

    public AudioSource neetleWalk;
    public AudioSource explode;
    public AudioSource sparks;

    public ParticleSystem plasmaExplodeOne;
    public ParticleSystem plasmaExplodeTwo;
    public ParticleSystem plasmaExplodeThree;
    public ParticleSystem plasmaExplodeFour;
    public ParticleSystem plasmaExplodeFive;
    public ParticleSystem plasmaExplodeSix;

    public ParticleSystem sparksFXOne;
    public ParticleSystem sparksFXTwo;
    public ParticleSystem sparksFXThree;
    public ParticleSystem sparksFXFour;
    public ParticleSystem sparksFXFive;

    public ParticleSystem sparksFXEnergyNodeOne;
    public ParticleSystem sparksFXEnergyNodeTwo;
    public ParticleSystem sparksFXEnergyNodeThree;

    public Animator neetleAnimator;





    public void CheckIfNeetleatExit()
    {
        if (gameManager.levelOneIsActive)
        {
            if (currentXAxis == 6 && currentYAxis == 4)
            {
                neetleInFinalLocation = true;
            }
        }
        else if (gameManager.levelTwoIsActive)
        {
            if (currentXAxis == 6 && currentYAxis == 4)
            {
                neetleInFinalLocation = true;
            }
        }
        else if (gameManager.levelThreeIsActive)
        {
            if (currentXAxis == 1 && currentYAxis == 1)
            {
                neetleInFinalLocation = true;
            }
        }
        else if (gameManager.levelFourIsActive)
        {
            if (currentXAxis == 4 && currentYAxis == 2)
            {
                neetleInFinalLocation = true;
            }
        }
        else if (gameManager.levelFiveIsActive)
        {
            if (currentXAxis == 3 && currentYAxis == 4)
            {
                neetleInFinalLocation = true;
            }
        }
        else if (gameManager.levelSixIsActive)
        {
            if (currentXAxis == 6 && currentYAxis == 1)
            {
                neetleInFinalLocation = true;
            }
        }
        else if (gameManager.levelSevenIsActive)
        {
                neetleInFinalLocation = false;
        }
    }

    //Show Move screen when click Neetle

    private void OnMouseDown()
    {
        if (screensAppear.GetComponent<ScreensAppear>().switchesScreen.activeSelf == true || screensAppear.GetComponent<ScreensAppear>().clockScreen.activeSelf == true || screensAppear.GetComponent<ScreensAppear>().hackScreen.activeSelf == true || screensAppear.GetComponent<ScreensAppear>().rollbonusScreen.activeSelf == true || screensAppear.GetComponent<ScreensAppear>().toolsScreen.activeSelf == true || screensAppear.GetComponent<ScreensAppear>().moveOptionsScreen.activeSelf == true)
        {
        }
        else
        {
            screensAppear.GetComponent<ScreensAppear>().MoveOptionsMenuIsOn();
            gameManager.select.Play();
        }
    }


    //add the active die to the movepad make diemovenumber the same.

    public void AddDieButtonIsClicked()
    {
        gameManager.select.Play();


        if (gameManager.mustUseClock == false)
        {
            if (gameManager.GetComponent<GameManager>().hasOne == true)
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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    //adds three movement when energy button is clicked

    public void EnergyButtonIsclicked()
    {
        gameManager.select.Play();
        gameManager.energyNumber -= 1;
        if (dieMoveNumber <= 3)
        {
            dieMoveNumber += 3;
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[dieMoveNumber - 1];
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
        gameManager.select.Play();
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
        gameManager.select.Play();
        neetleWalk.Play();
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
        gameManager.select.Play();
        neetleWalk.Play();
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
        gameManager.select.Play();
        neetleWalk.Play();
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
        gameManager.select.Play();
        neetleWalk.Play();
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
        gameManager.select.Play();
        neetleWalk.Play();
        currentYAxis += 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));

        dieMoveNumber -= 1;
        ChangeDieSprite();
    }

    public void LeftButtonIsClicked()
    {
        gameManager.select.Play();
        neetleWalk.Play();
        currentYAxis -= 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));

        dieMoveNumber -= 1;
        ChangeDieSprite();
    }

    public void UpButtonIsClicked()
    {
        gameManager.select.Play();
        neetleWalk.Play();
        currentXAxis -= 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));

        dieMoveNumber -= 1;
        ChangeDieSprite();
    }

    public void DownButtonIsClicked()
    {
        gameManager.select.Play();
        neetleWalk.Play();
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
            transform.LookAt(targetLocation.transform);
            neetleAnimator.SetBool("isMoving", true);

            /*
            Vector3 dir = targetLocation.transform.position - transform.position;
            dir.y = 0;
            // keep the direction strictly horizontal
            Quaternion rot = Quaternion.LookRotation(dir);
            // slerp to the desired rotation over time
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, rotationSpeed * Time.deltaTime);
            */

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
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[6];
        }
    }

    //check the locations orthogonally to neetle and allow movement if the die node is unlocked and switches have correct allignment

    private void CheckLeftLocationIsOpen()
    {

        // Level ONE CAN REMOVE ALL OF THIS AS IT IS THE OLD MOVING SCRIPT
        /*

        if (gameManager.levelOneIsActive)
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

        //level SIX THE SCRIPT BELOW IS NOW FOR ALL LEVELS


        else if (gameManager.levelSixIsActive)
        {

            */

            if (currentXAxis == 1 && currentYAxis == 1)
            {
                leftLocation = null;
                leftLocationIsOpen = false;
            }
            else if (currentXAxis == 1 && currentYAxis == 2)
            {
                leftLocation = mapMarkers[0];

                if (x1y1 == true)
                {
                    leftLocationIsOpen = true;
                }
                else
                {
                    leftLocationIsOpen = false;
                }
            }
            else if (currentXAxis == 1 && currentYAxis == 3)
            {
                leftLocation = mapMarkers[1];

                if (x1y2 == true)
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
                if (x1y3 == true)
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
                if (x2y1 == true)
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
                if (x2y2 == true)
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

                if (x2y3 == true)
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
                if (x3y1 == true)
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
                if (x3y2 == true)
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

                if (x3y3 == true)
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
                if (x4y1 == true)
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
                if (x4y2 == true)
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
                if (x4y3 == true)
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
                if (x5y1 == true)
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
                if (x5y2 == true)
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
                if (x5y3 == true)
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
                if (x6y1 == true)
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

                if (x6y2 == true)
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
                if (x6y3 == true)
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

                  if (x1y1 == true)
                  {
                     upLocationIsOpen = true;
                  }
                  else
                  {
                     upLocationIsOpen = false;
                  }
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

        if (gameManager.levelOneIsActive)
        {
            currentXAxis = 1;
            currentYAxis = 1;
            FindTargetLocation();
        }
        else if (gameManager.levelTwoIsActive)
        {
            currentXAxis = 1;
            currentYAxis = 1;
            FindTargetLocation();
        }

        else if (gameManager.levelThreeIsActive)
        {
            currentXAxis = 1;
            currentYAxis = 1;
            FindTargetLocation();
        }

        else if (gameManager.levelFourIsActive)
        {
            currentXAxis = 4;
            currentYAxis = 2;
            FindTargetLocation();
        }

        else if (gameManager.levelFiveIsActive)
        {
            currentXAxis = 3;
            currentYAxis = 4;
            FindTargetLocation();
        }
        else if(gameManager.levelSixIsActive)
        {
            currentXAxis = 6;
            currentYAxis = 1;
            FindTargetLocation();
        }
        else if (gameManager.levelSevenIsActive)
        {
            currentXAxis = 1;
            currentYAxis = 1;
            FindTargetLocation();
        }
    }

    // Update is called once per frame

    void Update()
    {



        CheckLeftLocationIsOpen();
        CheckRightLocationIsOpen();
        CheckUpLocationIsOpen();
        CheckDownLocationIsOpen();

        //check if tools are done and turn off
        if (tool1done == true)
        {
            if (gameManager.levelOneIsActive || gameManager.levelSixIsActive)
            {
                hacScreen.GetComponent<HackBehaviour>().tool1BLUE.SetActive(false);
            }
            else if (gameManager.levelTwoIsActive || gameManager.levelFiveIsActive)
            {
                hacScreen.GetComponent<Level2HackScript>().tool1BLUE.SetActive(false);
            }
            else if (gameManager.levelThreeIsActive || gameManager.levelFourIsActive)
            {
                hacScreen.GetComponent<Level3HackScript>().tool1BLUE.SetActive(false);
            }
        }
        if (tool2done == true)
        {
            if (gameManager.levelOneIsActive || gameManager.levelSixIsActive)
            {
                hacScreen.GetComponent<HackBehaviour>().tool2BLUE.SetActive(false);
            }
            else if (gameManager.levelTwoIsActive || gameManager.levelFiveIsActive)
            {
                hacScreen.GetComponent<Level2HackScript>().tool2BLUE.SetActive(false);
            }
            else if (gameManager.levelThreeIsActive || gameManager.levelFourIsActive)
            {
                hacScreen.GetComponent<Level3HackScript>().tool2BLUE.SetActive(false);
            }
        }
        if (tool3done == true)
        {
            if (gameManager.levelOneIsActive || gameManager.levelSixIsActive)
            {
                hacScreen.GetComponent<HackBehaviour>().tool3BLUE.SetActive(false);
            }
            else if (gameManager.levelTwoIsActive || gameManager.levelFiveIsActive)
            {
                hacScreen.GetComponent<Level2HackScript>().tool3BLUE.SetActive(false);
            }
            else if (gameManager.levelThreeIsActive || gameManager.levelFourIsActive)
            {
                hacScreen.GetComponent<Level3HackScript>().tool3BLUE.SetActive(false);
            }
        }
        if (tool4done == true)
        {
            if (gameManager.levelOneIsActive || gameManager.levelSixIsActive)
            {
                hacScreen.GetComponent<HackBehaviour>().tool4BLUE.SetActive(false);
            }
            else if (gameManager.levelTwoIsActive || gameManager.levelFiveIsActive)
            {
                hacScreen.GetComponent<Level2HackScript>().tool4BLUE.SetActive(false);
            }
            else if (gameManager.levelThreeIsActive || gameManager.levelFourIsActive)
            {
                hacScreen.GetComponent<Level3HackScript>().tool4BLUE.SetActive(false);
            }
        }
        if (tool5done == true)
        {
            if (gameManager.levelOneIsActive || gameManager.levelSixIsActive)
            {
                hacScreen.GetComponent<HackBehaviour>().tool5BLUE.SetActive(false);
            }
            else if (gameManager.levelTwoIsActive || gameManager.levelFiveIsActive)
            {
                hacScreen.GetComponent<Level2HackScript>().tool5BLUE.SetActive(false);
            }
            else if (gameManager.levelThreeIsActive || gameManager.levelFourIsActive)
            {
                hacScreen.GetComponent<Level3HackScript>().tool5BLUE.SetActive(false);
            }
        }
        if (tool6done == true)
        {
            if (gameManager.levelOneIsActive || gameManager.levelSixIsActive)
            {
                hacScreen.GetComponent<HackBehaviour>().tool6BLUE.SetActive(false);
            }
            else if (gameManager.levelTwoIsActive || gameManager.levelFiveIsActive)
            {
                hacScreen.GetComponent<Level2HackScript>().tool6BLUE.SetActive(false);
            }
            else if (gameManager.levelThreeIsActive || gameManager.levelFourIsActive)
            {
                hacScreen.GetComponent<Level3HackScript>().tool6BLUE.SetActive(false);
            }
        }


        if (neetleAnimator.GetBool("isMoving") == true)
        {

            Vector3 dir = targetLocation.transform.position - transform.position;
            dir.y = 0.1f;
            // keep the direction strictly horizontal
            Quaternion rot = Quaternion.LookRotation(dir);
            // slerp to the desired rotation over time
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, rotationSpeed * Time.deltaTime);

        }


        //turn off walking animation when idle

        if (neetle.transform.position == targetLocation.transform.position)
        {
            neetleAnimator.SetBool("isMoving", false);
        }

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
        if (currentYAxis == 4)
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

        //LEVEL ONE


        if (gameManager.levelOneIsActive == true)
        {
            x1y1 = true;

            if (unlockNode.DieSixnode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn))
            {
                x1y2 = true;
            }
            else
            {
                x1y2 = false;
            }

            if (unlockNode.DieOnenode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x1y3 = true;
            }
            else
            {
                x1y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x1y4 = true;
            }
            else
            {
                x1y4 = false;
            }

            if (unlockNode.DieFivenode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x2y1 = true;
            }
            else
            {
                x2y1 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x2y2 = true;
            }
            else
            {
                x2y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x2y3 = true;
            }
            else
            {
                x2y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x2y4 = true;
            }
            else
            {
                x2y4 = false;
            }

            if (unlockNode.DieTwonode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn))
            {
                x3y1 = true;
            }
            else
            {
                x3y1 = false;
            }

            if (unlockNode.DieSixnode2IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x3y2 = true;
            }
            else
            {
                x3y2 = false;
            }

            if (unlockNode.DieTwonode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x3y3 = true;
            }
            else
            {
                x3y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x3y4 = true;
            }
            else
            {
                x3y4 = false;
            }

            if (unlockNode.DieThreenode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x4y1 = true;
            }
            else
            {
                x4y1 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x4y2 = true;
            }
            else
            {
                x4y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x4y3 = true;
            }
            else
            {
                x4y3 = false;
            }

            if (unlockNode.DieFivenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x4y4 = true;
            }
            else
            {
                x4y4 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x5y1 = true;
            }
            else
            {
                x5y1 = false;
            }

            if (unlockNode.DieOnenode2IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x5y2 = true;
            }
            else
            {
                x5y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x5y3 = true;
            }
            else
            {
                x5y3 = false;
            }

            if (unlockNode.DieTwonode3IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x5y4 = true;
            }
            else
            {
                x5y4 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x6y1 = true;
            }
            else
            {
                x6y1 = false;
            }

            if (unlockNode.DieFournode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x6y2 = true;
            }
            else
            {
                x6y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x6y3 = true;
            }
            else
            {
                x6y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x6y4 = true;
            }
            else
            {
                x6y4 = false;
            }
        }

        // LEVEL TWO

        else if (gameManager.levelTwoIsActive == true)
        {
            x1y1 = true;

            if (unlockNode.DieSixnode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x1y2 = true;
            }
            else
            {
                x1y2 = false;
            }

            if (unlockNode.DieOnenode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x1y3 = true;
            }
            else
            {
                x1y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x1y4 = true;
            }
            else
            {
                x1y4 = false;
            }

            if (energyNode1.nodeIsUnlocked == true)
            {
                x2y1 = true;
            }
            else
            {
                x2y1 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x2y2 = true;
            }
            else
            {
                x2y2 = false;
            }

            if (unlockNode.DieFivenode1IsUnlocked == true && (!switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x2y3 = true;
            }
            else
            {
                x2y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x2y4 = true;
            }
            else
            {
                x2y4 = false;
            }

            if (unlockNode.DieOnenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x3y1 = true;
            }
            else
            {
                x3y1 = false;
            }

            if (unlockNode.DieFournode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x3y2 = true;
            }
            else
            {
                x3y2 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x3y3 = true;
            }
            else
            {
                x3y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x3y4 = true;
            }
            else
            {
                x3y4 = false;
            }

            if (unlockNode.DieTwonode2IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x4y1 = true;
            }
            else
            {
                x4y1 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x4y2 = true;
            }
            else
            {
                x4y2 = false;
            }

            if (unlockNode.DieFivenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x4y3 = true;
            }
            else
            {
                x4y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x4y4 = true;
            }
            else
            {
                x4y4 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x5y1 = true;
            }
            else
            {
                x5y1 = false;
            }

            if (energyNode2.nodeIsUnlocked == true)
            {
                x5y2 = true;
            }
            else
            {
                x5y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x5y3 = true;
            }
            else
            {
                x5y3 = false;
            }

            if (energyNode3.nodeIsUnlocked == true)
            {
                x5y4 = true;
            }
            else
            {
                x5y4 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x6y1 = true;
            }
            else
            {
                x6y1 = false;
            }

            if (unlockNode.DieSixnode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x6y2 = true;
            }
            else
            {
                x6y2 = false;
            }

            if (unlockNode.DieTwonode3IsUnlocked == true && (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x6y3 = true;
            }
            else
            {
                x6y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x6y4 = true;
            }
            else
            {
                x6y4 = false;
            }
        }

        // LEVEL THREE

        else if (gameManager.levelThreeIsActive == true)
        {
            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x1y1 = true;
            }
            else
            {
                x1y1 = false;
            }

            if (unlockNode.DieSixnode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x1y2 = true;
            }
            else
            {
                x1y2 = false;
            }

            if (unlockNode.DieOnenode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x1y3 = true;
            }
            else
            {
                x1y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x1y4 = true;
            }
            else
            {
                x1y4 = false;
            }

            if (unlockNode.DieTwonode3IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x2y1 = true;
            }
            else
            {
                x2y1 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x2y2 = true;
            }
            else
            {
                x2y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x2y3 = true;
            }
            else
            {
                x2y3 = false;
            }

            if (energyNode1.nodeIsUnlocked == true)
            {
                x2y4 = true;
            }
            else
            {
                x2y4 = false;
            }

            if (unlockNode.DieOnenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn))
            {
                x3y1 = true;
            }
            else
            {
                x3y1 = false;
            }

            if (unlockNode.DieFournode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x3y2 = true;
            }
            else
            {
                x3y2 = false;
            }

            if (unlockNode.DieFivenode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x3y3 = true;
            }
            else
            {
                x3y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x3y4 = true;
            }
            else
            {
                x3y4 = false;
            }

            if (unlockNode.DieTwonode2IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x4y1 = true;
            }
            else
            {
                x4y1 = false;
            }

            if (energyNode2.nodeIsUnlocked == true)
            {
                x4y2 = true;
            }
            else
            {
                x4y2 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x4y3 = true;
            }
            else
            {
                x4y3 = false;
            }

            if (unlockNode.DieFivenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x4y4 = true;
            }
            else
            {
                x4y4 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x5y1 = true;
            }
            else
            {
                x5y1 = false;
            }

            if (unlockNode.DieThreenode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x5y2 = true;
            }
            else
            {
                x5y2 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x5y3 = true;
            }
            else
            {
                x5y3 = false;
            }

            if (unlockNode.DieTwonode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x5y4 = true;
            }
            else
            {
                x5y4 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x6y1 = true;
            }
            else
            {
                x6y1 = false;
            }

            if (unlockNode.DieSixnode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x6y2 = true;
            }
            else
            {
                x6y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x6y3 = true;
            }
            else
            {
                x6y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x6y4 = true;
            }
            else
            {
                x6y4 = false;
            }
        }

        // LEVEL FOUR

        else if (gameManager.levelFourIsActive == true)
        {
            if (unlockNode.DieOnenode2IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x1y1 = true;
            }
            else
            {
                x1y1 = false;
            }

            if (unlockNode.DieSixnode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn))
            {
                x1y2 = true;
            }
            else
            {
                x1y2 = false;
            }

            if (energyNode1.nodeIsUnlocked == true)
            {
                x1y3 = true;
            }
            else
            {
                x1y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x1y4 = true;
            }
            else
            {
                x1y4 = false;
            }

            if (unlockNode.DieTwonode3IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x2y1 = true;
            }
            else
            {
                x2y1 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x2y2 = true;
            }
            else
            {
                x2y2 = false;
            }

            if (unlockNode.DieOnenode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x2y3 = true;
            }
            else
            {
                x2y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x2y4 = true;
            }
            else
            {
                x2y4 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x3y1 = true;
            }
            else
            {
                x3y1 = false;
            }

            if (unlockNode.DieFournode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x3y2 = true;
            }
            else
            {
                x3y2 = false;
            }

            if (unlockNode.DieFivenode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x3y3 = true;
            }
            else
            {
                x3y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x3y4 = true;
            }
            else
            {
                x3y4 = false;
            }

            if (unlockNode.DieTwonode2IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x4y1 = true;
            }
            else
            {
                x4y1 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x4y2 = true;
            }
            else
            {
                x4y2 = false;
            }

            if (energyNode2.nodeIsUnlocked == true)
            {
                x4y3 = true;
            }
            else
            {
                x4y3 = false;
            }

            if (unlockNode.DieFivenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x4y4 = true;
            }
            else
            {
                x4y4 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x5y1 = true;
            }
            else
            {
                x5y1 = false;
            }

            if (unlockNode.DieThreenode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x5y2 = true;
            }
            else
            {
                x5y2 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x5y3 = true;
            }
            else
            {
                x5y3 = false;
            }

            if (unlockNode.DieTwonode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x5y4 = true;
            }
            else
            {
                x5y4 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x6y1 = true;
            }
            else
            {
                x6y1 = false;
            }

            if (unlockNode.DieSixnode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x6y2 = true;
            }
            else
            {
                x6y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x6y3 = true;
            }
            else
            {
                x6y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x6y4 = true;
            }
            else
            {
                x6y4 = false;
            }
        }

        // LEVEL FIVE

        else if (gameManager.levelFiveIsActive == true)
        {
            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x1y1 = true;
            }
            else
            {
                x1y1 = false;
            }

            if (unlockNode.DieSixnode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn))
            {
                x1y2 = true;
            }
            else
            {
                x1y2 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x1y3 = true;
            }
            else
            {
                x1y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x1y4 = true;
            }
            else
            {
                x1y4 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x2y1 = true;
            }
            else
            {
                x2y1 = false;
            }

            if (unlockNode.DieTwonode2IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x2y2 = true;
            }
            else
            {
                x2y2 = false;
            }

            if (unlockNode.DieFivenode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x2y3 = true;
            }
            else
            {
                x2y3 = false;
            }

            if (unlockNode.DieTwonode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x2y4 = true;
            }
            else
            {
                x2y4 = false;
            }

            if (unlockNode.DieOnenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x3y1 = true;
            }
            else
            {
                x3y1 = false;
            }

            if (unlockNode.DieFournode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x3y2 = true;
            }
            else
            {
                x3y2 = false;
            }

            if (unlockNode.DieOnenode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x3y3 = true;
            }
            else
            {
                x3y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x3y4 = true;
            }
            else
            {
                x3y4 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x4y1 = true;
            }
            else
            {
                x4y1 = false;
            }

            if (energyNode1.nodeIsUnlocked == true)
            {
                x4y2 = true;
            }
            else
            {
                x4y2 = false;
            }

            if (unlockNode.DieFivenode2IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x4y3 = true;
            }
            else
            {
                x4y3 = false;
            }

            if (energyNode2.nodeIsUnlocked == true)
            {
                x4y4 = true;
            }
            else
            {
                x4y4 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x5y1 = true;
            }
            else
            {
                x5y1 = false;
            }

            if (unlockNode.DieTwonode3IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x5y2 = true;
            }
            else
            {
                x5y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x5y3 = true;
            }
            else
            {
                x5y3 = false;
            }

            if (unlockNode.DieThreenode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x5y4 = true;
            }
            else
            {
                x5y4 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x6y1 = true;
            }
            else
            {
                x6y1 = false;
            }

            if (unlockNode.DieSixnode2IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x6y2 = true;
            }
            else
            {
                x6y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x6y3 = true;
            }
            else
            {
                x6y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x6y4 = true;
            }
            else
            {
                x6y4 = false;
            }
        }


        // LEVEL SIX

        else if (gameManager.levelSixIsActive == true)
        {
            if (!switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || !switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x1y1 = true;
            }
            else
            {
                x1y1 = false;
            }

            if (unlockNode.DieSixnode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn))
            {
                x1y2 = true;
            }
            else
            {
                x1y2 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x1y3 = true;
            }
            else
            {
                x1y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x1y4 = true;
            }
            else
            {
                x1y4 = false;
            }

            if (unlockNode.DieFournode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x2y1 = true;
            }
            else
            {
                x2y1 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x2y2 = true;
            }
            else
            {
                x2y2 = false;
            }

            if (unlockNode.DieFivenode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x2y3 = true;
            }
            else
            {
                x2y3 = false;
            }

            if (unlockNode.DieThreenode1IsUnlocked == true && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x2y4 = true;
            }
            else
            {
                x2y4 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x3y1 = true;
            }
            else
            {
                x3y1 = false;
            }

            if (energyNode1.nodeIsUnlocked == true)
            {
                x3y2 = true;
            }
            else
            {
                x3y2 = false;
            }

            if (unlockNode.DieOnenode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x3y3 = true;
            }
            else
            {
                x3y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x3y4 = true;
            }
            else
            {
                x3y4 = false;
            }

            if (unlockNode.DieTwonode2IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x4y1 = true;
            }
            else
            {
                x4y1 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x4y2 = true;
            }
            else
            {
                x4y2 = false;
            }

            if (unlockNode.DieFivenode2IsUnlocked == true && (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x4y3 = true;
            }
            else
            {
                x4y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x4y4 = true;
            }
            else
            {
                x4y4 = false;
            }

            if (unlockNode.DieOnenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x5y1 = true;
            }
            else
            {
                x5y1 = false;
            }

            if (energyNode2.nodeIsUnlocked == true)
            {
                x5y2 = true;
            }
            else
            {
                x5y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x5y3 = true;
            }
            else
            {
                x5y3 = false;
            }

            if (unlockNode.DieTwonode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x5y4 = true;
            }
            else
            {
                x5y4 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x6y1 = true;
            }
            else
            {
                x6y1 = false;
            }

            if (unlockNode.DieSixnode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x6y2 = true;
            }
            else
            {
                x6y2 = false;
            }

            if (unlockNode.DieTwonode3IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x6y3 = true;
            }
            else
            {
                x6y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x6y4 = true;
            }
            else
            {
                x6y4 = false;
            }
        }

        // LEVEL SEVEN

        else if (gameManager.levelSevenIsActive == true)
        {

            x1y1 = true;

            if (unlockNode.DieSixnode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn))
            {
                x1y2 = true;
            }
            else
            {
                x1y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x1y3 = true;
            }
            else
            {
                x1y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x1y4 = true;
            }
            else
            {
                x1y4 = false;
            }

            if (unlockNode.DieFournode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x2y1 = true;
            }
            else
            {
                x2y1 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x2y2 = true;
            }
            else
            {
                x2y2 = false;
            }

            if (energyNode1.nodeIsUnlocked == true)
            {
                x2y3 = true;
            }
            else
            {
                x2y3 = false;
            }

            if (unlockNode.DieOnenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x2y4 = true;
            }
            else
            {
                x2y4 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x3y1 = true;
            }
            else
            {
                x3y1 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x3y2 = true;
            }
            else
            {
                x3y2 = false;
            }

            if (unlockNode.DieOnenode1IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x3y3 = true;
            }
            else
            {
                x3y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn)
            {
                x3y4 = true;
            }
            else
            {
                x3y4 = false;
            }

            if (unlockNode.DieTwonode2IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x4y1 = true;
            }
            else
            {
                x4y1 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn)
            {
                x4y2 = true;
            }
            else
            {
                x4y2 = false;
            }

            if (unlockNode.DieFivenode2IsUnlocked == true && (!switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x4y3 = true;
            }
            else
            {
                x4y3 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn && !switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x4y4 = true;
            }
            else
            {
                x4y4 = false;
            }

            if (unlockNode.DieOnenode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x5y1 = true;
            }
            else
            {
                x5y1 = false;
            }

            if (energyNode2.nodeIsUnlocked == true)
            {
                x5y2 = true;
            }
            else
            {
                x5y2 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchFiveIsOn)
            {
                x5y3 = true;
            }
            else
            {
                x5y3 = false;
            }

            if (unlockNode.DieTwonode1IsUnlocked == true && !switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn)
            {
                x5y4 = true;
            }
            else
            {
                x5y4 = false;
            }

            if (!switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn)
            {
                x6y1 = true;
            }
            else
            {
                x6y1 = false;
            }

            if (unlockNode.DieSixnode2IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchOneIsOn || switchPanel.GetComponent<SwitchBehaviour>().switchSixIsOn))
            {
                x6y2 = true;
            }
            else
            {
                x6y2 = false;
            }

            if (unlockNode.DieTwonode3IsUnlocked == true && (switchPanel.GetComponent<SwitchBehaviour>().switchThreeIsOn && switchPanel.GetComponent<SwitchBehaviour>().switchFourIsOn))
            {
                x6y3 = true;
            }
            else
            {
                x6y3 = false;
            }

            if (switchPanel.GetComponent<SwitchBehaviour>().switchTwoIsOn)
            {
                x6y4 = true;
            }
            else
            {
                x6y4 = false;
            }

        }

            //Check if neetle has entered a bonus location and give bonus, turn node green then stop allowing bonus

            //Level ONE

            if (gameManager.levelOneIsActive)
            {
                if ((currentXAxis == 6 && currentYAxis == 3) && bonusMultitools == false)
                {
                    gameManager.multitoolNumber += 2;
                    bonusMultitools = true;
                    bonusMultitoolsNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXFive.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 4 && currentYAxis == 3) && bonusEnergy == false)
                {
                    gameManager.energyNumber += 1;
                    bonusEnergy = true;
                    bonusEnergyNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXThree.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 4) && bonusCredit1 == false)
                {
                    gameManager.creditNumber += 1;
                    bonusCredit1 = true;
                    bonusCreditNode1.GetComponent<MeshRenderer>().material = green;
                    sparksFXTwo.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 5 && currentYAxis == 1) && bonusCredit2 == false)
                {
                    gameManager.creditNumber += 1;
                    bonusCredit2 = true;
                    bonusCreditNode2.GetComponent<MeshRenderer>().material = green;
                    sparksFXFour.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 3) && bonusMultitool == false)
                {
                    gameManager.multitoolNumber += 1;
                    bonusMultitool = true;
                    bonusMultitoolNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXOne.Play();
                    sparks.Play();
                }
            }

            //Level TWO

            else if (gameManager.levelTwoIsActive)
            {

                if ((currentXAxis == 3 && currentYAxis == 3) && bonusMultitools == false)
                {
                    gameManager.multitoolNumber += 1;
                    bonusMultitools = true;
                    bonusMultitoolsNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXFive.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 4 && currentYAxis == 4) && bonusEnergy == false)
                {
                    gameManager.energyNumber += 1;
                    bonusEnergy = true;
                    bonusEnergyNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXThree.Play();
                    sparks.Play();
                }


                if ((currentXAxis == 2 && currentYAxis == 4) && bonusCredit1 == false)
                {
                    gameManager.creditNumber += 1;
                    bonusCredit1 = true;
                    bonusCreditNode1.GetComponent<MeshRenderer>().material = green;
                    sparksFXTwo.Play();
                    sparks.Play();
                }



                if ((currentXAxis == 5 && currentYAxis == 1) && bonusMultitool == false)
                {
                    gameManager.creditNumber += 1;
                    bonusMultitool = true;
                    bonusMultitoolNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXOne.Play();
                    sparks.Play();
                }
            }

            //Level THREE

            else if (gameManager.levelThreeIsActive)
            {

                if ((currentXAxis == 2 && currentYAxis == 3) && bonusMultitools == false)
                {
                    gameManager.multitoolNumber += 1;
                    bonusMultitools = true;
                    bonusMultitoolsNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXFive.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 4 && currentYAxis == 3) && bonusEnergy == false)
                {
                    gameManager.energyNumber += 1;
                    bonusEnergy = true;
                    bonusEnergyNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXThree.Play();
                    sparks.Play();
                }


                if ((currentXAxis == 5 && currentYAxis == 1) && bonusCredit1 == false)
                {
                    gameManager.creditNumber += 1;
                    bonusCredit1 = true;
                    bonusCreditNode1.GetComponent<MeshRenderer>().material = green;
                    sparksFXTwo.Play();
                    sparks.Play();
                }



                if ((currentXAxis == 6 && currentYAxis == 3) && bonusMultitool == false)
                {
                    gameManager.multitoolNumber += 2;
                    bonusMultitool = true;
                    bonusMultitoolNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXOne.Play();
                    sparks.Play();
                }
            }

            //Level FOUR

            else if (gameManager.levelFourIsActive)
            {

                if ((currentXAxis == 3 && currentYAxis == 1) && bonusMultitools == false)
                {
                    gameManager.multitoolNumber += 1;
                    bonusMultitools = true;
                    bonusMultitoolsNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXFive.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 4) && bonusEnergy == false)
                {
                    gameManager.energyNumber += 1;
                    bonusEnergy = true;
                    bonusEnergyNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXThree.Play();
                    sparks.Play();
                }


                if ((currentXAxis == 5 && currentYAxis == 1) && bonusCredit1 == false)
                {
                    gameManager.creditNumber += 1;
                    bonusCredit1 = true;
                    bonusCreditNode1.GetComponent<MeshRenderer>().material = green;
                    sparksFXTwo.Play();
                    sparks.Play();
                }



                if ((currentXAxis == 6 && currentYAxis == 3) && bonusMultitool == false)
                {
                    gameManager.multitoolNumber += 2;
                    bonusMultitool = true;
                    bonusMultitoolNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXOne.Play();
                    sparks.Play();
                }
            }

            //Level FIVE

            else if (gameManager.levelFiveIsActive)
            {

                if ((currentXAxis == 1 && currentYAxis == 3) && bonusMultitools == false)
                {
                    gameManager.multitoolNumber += 1;
                    bonusMultitools = true;
                    bonusMultitoolsNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXFive.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 1) && bonusEnergy == false)
                {
                    gameManager.energyNumber += 1;
                    bonusEnergy = true;
                    bonusEnergyNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXThree.Play();
                    sparks.Play();
                }


                if ((currentXAxis == 5 && currentYAxis == 1) && bonusCredit1 == false)
                {
                    gameManager.creditNumber += 1;
                    bonusCredit1 = true;
                    bonusCreditNode1.GetComponent<MeshRenderer>().material = green;
                    sparksFXTwo.Play();
                    sparks.Play();
                }



                if ((currentXAxis == 6 && currentYAxis == 3) && bonusMultitool == false)
                {
                    gameManager.multitoolNumber += 1;
                    bonusMultitool = true;
                    bonusMultitoolNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXOne.Play();
                    sparks.Play();
                }
            }


            //Level SIX

            else if (gameManager.levelSixIsActive)
            {

                if ((currentXAxis == 3 && currentYAxis == 1) && bonusMultitools == false)
                {
                    gameManager.multitoolNumber += 1;
                    bonusMultitools = true;
                    bonusMultitoolsNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXFive.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 4 && currentYAxis == 4) && bonusEnergy == false)
                {
                    gameManager.energyNumber += 1;
                    bonusEnergy = true;
                    bonusEnergyNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXThree.Play();
                    sparks.Play();
                }


                if ((currentXAxis == 1 && currentYAxis == 3) && bonusCredit1 == false)
                {
                    gameManager.creditNumber += 1;
                    bonusCredit1 = true;
                    bonusCreditNode1.GetComponent<MeshRenderer>().material = green;
                    sparksFXTwo.Play();
                    sparks.Play();
                }



                if ((currentXAxis == 4 && currentYAxis == 2) && bonusMultitool == false)
                {
                    gameManager.multitoolNumber += 1;
                    bonusMultitool = true;
                    bonusMultitoolNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXOne.Play();
                    sparks.Play();
                }
            }

            //Level SEVEN

            else if (gameManager.levelSevenIsActive)
            {

                if ((currentXAxis == 1 && currentYAxis == 3) && bonusMultitools == false)
                {
                    gameManager.multitoolNumber += 1;
                    bonusMultitools = true;
                    bonusMultitoolsNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXFive.Play();
                    sparks.Play();
                }

                if ((currentXAxis == 4 && currentYAxis == 3) && bonusEnergy == false)
                {
                    gameManager.energyNumber += 1;
                    bonusEnergy = true;
                    bonusEnergyNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXThree.Play();
                    sparks.Play();
                }


                if ((currentXAxis == 5 && currentYAxis == 1) && bonusCredit1 == false)
                {
                    gameManager.creditNumber += 1;
                    bonusCredit1 = true;
                    bonusCreditNode1.GetComponent<MeshRenderer>().material = green;
                    sparksFXTwo.Play();
                    sparks.Play();
                }



                if ((currentXAxis == 3 && currentYAxis == 2) && bonusMultitool == false)
                {
                    gameManager.multitoolNumber += 2;
                    bonusMultitool = true;
                    bonusMultitoolNode.GetComponent<MeshRenderer>().material = green;
                    sparksFXOne.Play();
                    sparks.Play();
                }
            }

            //Check if have tool when entering tool node and activate node if you do


            //Level ONE

            if (gameManager.levelOneIsActive)
            {

                if ((currentXAxis == 1 && currentYAxis == 4) && (hacScreen.GetComponent<HackBehaviour>().hasTool2 == true && tool2done == false))
                {
                    tool2done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool2.SetActive(true);

                    toolNodes[1].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 12;
                    gameManager.nedDamage += 12;
                    hacScreen.GetComponent<HackBehaviour>().hasTool2 = false;
                    plasmaExplodeTwo.Play();
                    explode.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 2) && (hacScreen.GetComponent<HackBehaviour>().hasTool1 == true && tool1done == false))
                {
                    
                    tool1done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool1.SetActive(true);
                    toolNodes[0].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 9;
                    gameManager.nedDamage += 9;
                    hacScreen.GetComponent<HackBehaviour>().hasTool1 = false;
                    plasmaExplodeOne.Play();
                    explode.Play();
                }

                if ((currentXAxis == 3 && currentYAxis == 4) && (hacScreen.GetComponent<HackBehaviour>().hasTool4 == true && tool4done == false))
                {
                    tool4done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool4.SetActive(true);
                    toolNodes[3].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<HackBehaviour>().hasTool4 = false;
                    plasmaExplodeFour.Play();
                    explode.Play();
                }

                if ((currentXAxis == 4 && currentYAxis == 2) && (hacScreen.GetComponent<HackBehaviour>().hasTool5 == true && tool5done == false))
                {
                    tool5done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool5.SetActive(true);
                    toolNodes[4].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<HackBehaviour>().hasTool5 = false;
                    plasmaExplodeFive.Play();
                    explode.Play();
                }

                if ((currentXAxis == 5 && currentYAxis == 3) && (hacScreen.GetComponent<HackBehaviour>().hasTool3 == true && tool3done == false))
                {
                    tool3done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool3.SetActive(true);
                    toolNodes[2].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 17;
                    gameManager.nedDamage += 17;
                    hacScreen.GetComponent<HackBehaviour>().hasTool3 = false;
                    plasmaExplodeThree.Play();
                    explode.Play();
                }

                if ((currentXAxis == 6 && currentYAxis == 1) && (hacScreen.GetComponent<HackBehaviour>().hasTool6 == true && tool6done == false))
                {
                    tool6done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool6.SetActive(true);
                    toolNodes[5].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 20;
                    gameManager.nedDamage += 20;
                    hacScreen.GetComponent<HackBehaviour>().hasTool6 = false;
                    plasmaExplodeSix.Play();
                    explode.Play();
                }
            }

            //Level TWO

            else if (gameManager.levelTwoIsActive)
            {
                if ((currentXAxis == 1 && currentYAxis == 4) && (hacScreen.GetComponent<Level2HackScript>().hasTool2 == true && tool2done == false))
                {
                    tool2done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool2.SetActive(true);

                    toolNodes[1].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 12;
                    gameManager.nedDamage += 12;
                    hacScreen.GetComponent<Level2HackScript>().hasTool2 = false;
                    plasmaExplodeTwo.Play();
                    explode.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 2) && (hacScreen.GetComponent<Level2HackScript>().hasTool1 == true && tool1done == false))
                {
                    tool1done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool1.SetActive(true);
                    toolNodes[0].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 9;
                    gameManager.nedDamage += 9;
                    hacScreen.GetComponent<Level2HackScript>().hasTool1 = false;
                    plasmaExplodeOne.Play();
                    explode.Play();
                }

                if ((currentXAxis == 3 && currentYAxis == 4) && (hacScreen.GetComponent<Level2HackScript>().hasTool5 == true && tool4done == false))
                {
                    tool4done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool5.SetActive(true);
                    toolNodes[3].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<Level2HackScript>().hasTool5 = false;
                    plasmaExplodeFour.Play();
                    explode.Play();
                }

                if ((currentXAxis == 4 && currentYAxis == 2) && (hacScreen.GetComponent<Level2HackScript>().hasTool6 == true && tool5done == false))
                {
                    tool5done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool6.SetActive(true);
                    toolNodes[4].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<Level2HackScript>().hasTool6 = false;
                    plasmaExplodeFive.Play();
                    explode.Play();
                }

                if ((currentXAxis == 5 && currentYAxis == 3) && (hacScreen.GetComponent<Level2HackScript>().hasTool3 == true && tool3done == false))
                {
                    tool3done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool3.SetActive(true);
                    toolNodes[2].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 17;
                    gameManager.nedDamage += 17;
                    hacScreen.GetComponent<Level2HackScript>().hasTool3 = false;
                    plasmaExplodeThree.Play();
                    explode.Play();
                }

                if ((currentXAxis == 6 && currentYAxis == 1) && (hacScreen.GetComponent<Level2HackScript>().hasTool4 == true && tool6done == false))
                {
                    tool6done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool4.SetActive(true);
                    toolNodes[5].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 20;
                    gameManager.nedDamage += 20;
                    hacScreen.GetComponent<Level2HackScript>().hasTool4 = false;
                    plasmaExplodeSix.Play();
                    explode.Play();
                }
            }

            //Level THREE

            else if (gameManager.levelThreeIsActive)
            {
                if ((currentXAxis == 1 && currentYAxis == 4) && (hacScreen.GetComponent<Level3HackScript>().hasTool2 == true && tool2done == false))
                {
                    tool2done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool2.SetActive(true);

                    toolNodes[1].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 12;
                    gameManager.nedDamage += 12;
                    hacScreen.GetComponent<Level3HackScript>().hasTool2 = false;
                    plasmaExplodeTwo.Play();
                    explode.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 2) && (hacScreen.GetComponent<Level3HackScript>().hasTool1 == true && tool1done == false))
                {
                    tool1done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool1.SetActive(true);
                    toolNodes[0].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 9;
                    gameManager.nedDamage += 9;
                    hacScreen.GetComponent<Level3HackScript>().hasTool1 = false;
                    plasmaExplodeOne.Play();
                    explode.Play();
                }

                if ((currentXAxis == 3 && currentYAxis == 4) && (hacScreen.GetComponent<Level3HackScript>().hasTool5 == true && tool4done == false))
                {
                    tool4done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool5.SetActive(true);
                    toolNodes[3].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<Level3HackScript>().hasTool5 = false;
                    plasmaExplodeFour.Play();
                    explode.Play();
                }

                if ((currentXAxis == 6 && currentYAxis == 4) && (hacScreen.GetComponent<Level3HackScript>().hasTool6 == true && tool5done == false))
                {
                    tool5done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool6.SetActive(true);
                    toolNodes[4].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 20;
                    gameManager.nedDamage += 20;
                    hacScreen.GetComponent<Level3HackScript>().hasTool6 = false;
                    plasmaExplodeFive.Play();
                    explode.Play();
                }

                if ((currentXAxis == 5 && currentYAxis == 3) && (hacScreen.GetComponent<Level3HackScript>().hasTool3 == true && tool3done == false))
                {
                    tool3done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool3.SetActive(true);
                    toolNodes[2].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 17;
                    gameManager.nedDamage += 17;
                    hacScreen.GetComponent<Level3HackScript>().hasTool3 = false;
                    plasmaExplodeThree.Play();
                    explode.Play();
                }

                if ((currentXAxis == 6 && currentYAxis == 1) && (hacScreen.GetComponent<Level3HackScript>().hasTool4 == true && tool6done == false))
                {
                    tool6done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool4.SetActive(true);
                    toolNodes[5].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 17;
                    gameManager.nedDamage += 17;
                    hacScreen.GetComponent<Level3HackScript>().hasTool4 = false;
                    plasmaExplodeSix.Play();
                    explode.Play();
                }
            }

            //Level FOUR

            else if (gameManager.levelFourIsActive)
            {
                if ((currentXAxis == 6 && currentYAxis == 1) && (hacScreen.GetComponent<Level3HackScript>().hasTool2 == true && tool2done == false))
                {
                    tool2done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool2.SetActive(true);

                    toolNodes[1].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 12;
                    gameManager.nedDamage += 12;
                    hacScreen.GetComponent<Level3HackScript>().hasTool2 = false;
                    plasmaExplodeTwo.Play();
                    explode.Play();
                }

                if ((currentXAxis == 5 && currentYAxis == 3) && (hacScreen.GetComponent<Level3HackScript>().hasTool1 == true && tool1done == false))
                {
                    tool1done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool1.SetActive(true);
                    toolNodes[0].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 9;
                    gameManager.nedDamage += 9;
                    hacScreen.GetComponent<Level3HackScript>().hasTool1 = false;
                    plasmaExplodeOne.Play();
                    explode.Play();
                }

                if ((currentXAxis == 3 && currentYAxis == 4) && (hacScreen.GetComponent<Level3HackScript>().hasTool5 == true && tool4done == false))
                {
                    tool4done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool5.SetActive(true);
                    toolNodes[3].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<Level3HackScript>().hasTool5 = false;
                    plasmaExplodeFour.Play();
                    explode.Play();
                }

                if ((currentXAxis == 6 && currentYAxis == 4) && (hacScreen.GetComponent<Level3HackScript>().hasTool6 == true && tool5done == false))
                {
                    tool5done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool6.SetActive(true);
                    toolNodes[4].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 20;
                    gameManager.nedDamage += 20;
                    hacScreen.GetComponent<Level3HackScript>().hasTool6 = false;
                    plasmaExplodeFive.Play();
                    explode.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 2) && (hacScreen.GetComponent<Level3HackScript>().hasTool3 == true && tool3done == false))
                {
                    tool3done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool3.SetActive(true);
                    toolNodes[2].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 17;
                    gameManager.nedDamage += 17;
                    hacScreen.GetComponent<Level3HackScript>().hasTool3 = false;
                    plasmaExplodeThree.Play();
                    explode.Play();
                }

                if ((currentXAxis == 1 && currentYAxis == 4) && (hacScreen.GetComponent<Level3HackScript>().hasTool4 == true && tool6done == false))
                {
                    tool6done = true;
                    hacScreen.GetComponent<Level3HackScript>().tool4.SetActive(true);
                    toolNodes[5].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 17;
                    gameManager.nedDamage += 17;
                    hacScreen.GetComponent<Level3HackScript>().hasTool4 = false;
                    plasmaExplodeSix.Play();
                    explode.Play();
                }
            }

            //Level FIVE

            else if (gameManager.levelFiveIsActive)
            {
                if ((currentXAxis == 1 && currentYAxis == 4) && (hacScreen.GetComponent<Level2HackScript>().hasTool2 == true && tool2done == false))
                {
                    tool2done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool2.SetActive(true);

                    toolNodes[1].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 12;
                    gameManager.nedDamage += 12;
                    hacScreen.GetComponent<Level2HackScript>().hasTool2 = false;
                    plasmaExplodeTwo.Play();
                    explode.Play();
                }

                if ((currentXAxis == 5 && currentYAxis == 3) && (hacScreen.GetComponent<Level2HackScript>().hasTool1 == true && tool1done == false))
                {
                    tool1done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool1.SetActive(true);
                    toolNodes[0].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 9;
                    gameManager.nedDamage += 9;
                    hacScreen.GetComponent<Level2HackScript>().hasTool1 = false;
                    plasmaExplodeOne.Play();
                    explode.Play();
                }

                if ((currentXAxis == 4 && currentYAxis == 1) && (hacScreen.GetComponent<Level2HackScript>().hasTool5 == true && tool4done == false))
                {
                    tool4done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool5.SetActive(true);
                    toolNodes[3].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<Level2HackScript>().hasTool5 = false;
                    plasmaExplodeFour.Play();
                    explode.Play();
                }

                if ((currentXAxis == 6 && currentYAxis == 4) && (hacScreen.GetComponent<Level2HackScript>().hasTool6 == true && tool5done == false))
                {
                    tool5done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool6.SetActive(true);
                    toolNodes[4].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<Level2HackScript>().hasTool6 = false;
                    plasmaExplodeFive.Play();
                    explode.Play();
                }

                if ((currentXAxis == 6 && currentYAxis == 1) && (hacScreen.GetComponent<Level2HackScript>().hasTool3 == true && tool3done == false))
                {
                    tool3done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool3.SetActive(true);
                    toolNodes[2].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 17;
                    gameManager.nedDamage += 17;
                    hacScreen.GetComponent<Level2HackScript>().hasTool3 = false;
                    plasmaExplodeThree.Play();
                    explode.Play();
                }

                if ((currentXAxis == 1 && currentYAxis == 1) && (hacScreen.GetComponent<Level2HackScript>().hasTool4 == true && tool6done == false))
                {
                    tool6done = true;
                    hacScreen.GetComponent<Level2HackScript>().tool4.SetActive(true);
                    toolNodes[5].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 20;
                    gameManager.nedDamage += 20;
                    hacScreen.GetComponent<Level2HackScript>().hasTool4 = false;
                    plasmaExplodeSix.Play();
                    explode.Play();
                }
            }


            //Level SIX

            else if (gameManager.levelSixIsActive)
            {
                if ((currentXAxis == 1 && currentYAxis == 4) && (hacScreen.GetComponent<HackBehaviour>().hasTool2 == true && tool2done == false))
                {
                    tool2done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool2.SetActive(true);

                    toolNodes[1].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 20;
                    gameManager.nedDamage += 20;
                    hacScreen.GetComponent<HackBehaviour>().hasTool2 = false;
                    plasmaExplodeTwo.Play();
                    explode.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 2) && (hacScreen.GetComponent<HackBehaviour>().hasTool1 == true && tool1done == false))
                {
                    tool1done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool1.SetActive(true);
                    toolNodes[0].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<HackBehaviour>().hasTool1 = false;
                    plasmaExplodeOne.Play();
                    explode.Play();
                }

                if ((currentXAxis == 3 && currentYAxis == 4) && (hacScreen.GetComponent<HackBehaviour>().hasTool4 == true && tool4done == false))
                {
                    tool4done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool4.SetActive(true);
                    toolNodes[3].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 15;
                    gameManager.nedDamage += 15;
                    hacScreen.GetComponent<HackBehaviour>().hasTool4 = false;
                    plasmaExplodeFour.Play();
                    explode.Play();
                }

                if ((currentXAxis == 6 && currentYAxis == 4) && (hacScreen.GetComponent<HackBehaviour>().hasTool5 == true && tool5done == false))
                {
                    tool5done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool5.SetActive(true);
                    toolNodes[4].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 12;
                    gameManager.nedDamage += 12;
                    hacScreen.GetComponent<HackBehaviour>().hasTool5 = false;
                    plasmaExplodeFive.Play();
                    explode.Play();
                }

                if ((currentXAxis == 5 && currentYAxis == 3) && (hacScreen.GetComponent<HackBehaviour>().hasTool3 == true && tool3done == false))
                {
                    tool3done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool3.SetActive(true);
                    toolNodes[2].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 9;
                    gameManager.nedDamage += 9;
                    hacScreen.GetComponent<HackBehaviour>().hasTool3 = false;
                    plasmaExplodeThree.Play();
                    explode.Play();
                }

                if ((currentXAxis == 1 && currentYAxis == 1) && (hacScreen.GetComponent<HackBehaviour>().hasTool6 == true && tool6done == false))
                {
                    tool6done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool6.SetActive(true);
                    toolNodes[5].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 17;
                    gameManager.nedDamage += 17;
                    hacScreen.GetComponent<HackBehaviour>().hasTool6 = false;
                    plasmaExplodeSix.Play();
                    explode.Play();
                }
            }

            //Level SEVEN

            else if (gameManager.levelSevenIsActive)
            {
                if ((currentXAxis == 1 && currentYAxis == 4) && (hacScreen.GetComponent<HackBehaviour>().hasTool2 == true && tool2done == false))
                {
                    tool2done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool2.SetActive(true);

                    toolNodes[1].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 0;
                    gameManager.nedDamage += 0;
                    hacScreen.GetComponent<HackBehaviour>().hasTool2 = false;
                    plasmaExplodeTwo.Play();
                    explode.Play();
                }

                if ((currentXAxis == 2 && currentYAxis == 2) && (hacScreen.GetComponent<HackBehaviour>().hasTool1 == true && tool1done == false))
                {
                    tool1done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool1.SetActive(true);
                    toolNodes[0].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 0;
                    gameManager.nedDamage += 0;
                    hacScreen.GetComponent<HackBehaviour>().hasTool1 = false;
                    plasmaExplodeOne.Play();
                    explode.Play();
                }

                if ((currentXAxis == 3 && currentYAxis == 4) && (hacScreen.GetComponent<HackBehaviour>().hasTool4 == true && tool4done == false))
                {
                    tool4done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool4.SetActive(true);
                    toolNodes[3].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 0;
                    gameManager.nedDamage += 0;
                    hacScreen.GetComponent<HackBehaviour>().hasTool4 = false;
                    plasmaExplodeFour.Play();
                    explode.Play();
                }

                if ((currentXAxis == 3 && currentYAxis == 1) && (hacScreen.GetComponent<HackBehaviour>().hasTool5 == true && tool5done == false))
                {
                    tool5done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool5.SetActive(true);
                    toolNodes[4].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 0;
                    gameManager.nedDamage += 0;
                    hacScreen.GetComponent<HackBehaviour>().hasTool5 = false;
                    plasmaExplodeFive.Play();
                    explode.Play();
                }

                if ((currentXAxis == 5 && currentYAxis == 3) && (hacScreen.GetComponent<HackBehaviour>().hasTool3 == true && tool3done == false))
                {
                    tool3done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool3.SetActive(true);
                    toolNodes[2].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 0;
                    gameManager.nedDamage += 0;
                    hacScreen.GetComponent<HackBehaviour>().hasTool3 = false;
                    plasmaExplodeThree.Play();
                    explode.Play();
                }

                if ((currentXAxis == 1 && currentYAxis == 1) && (hacScreen.GetComponent<HackBehaviour>().hasTool6 == true && tool6done == false))
                {
                    tool6done = true;
                    hacScreen.GetComponent<HackBehaviour>().tool6.SetActive(true);
                    toolNodes[5].GetComponent<MeshRenderer>().material = green;
                    gameManager.damageNumber += 0;
                    gameManager.nedDamage += 0;
                    hacScreen.GetComponent<HackBehaviour>().hasTool6 = false;
                    plasmaExplodeSix.Play();
                    explode.Play();
                }
            }

        
    }
}
