using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NeetleBehaviour : MonoBehaviour
{
    private int currentXAxis;
    private int currentYAxis;

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

    //add the active die to the movepad make diemovenumber the same.

    public void AddDieButtonIsClicked()
    {
        if(gameManager.GetComponent<GameManager>().hasOne == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[0];
            dieMoveNumber = 1;
            
          

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

        else if (gameManager.GetComponent<GameManager>().hasTwo == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[1];
            dieMoveNumber = 2;
            
       

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

        else if (gameManager.GetComponent<GameManager>().hasThree == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[2];
            dieMoveNumber = 3;
            
           

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
        else if (gameManager.GetComponent<GameManager>().hasFour == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[3];
            dieMoveNumber = 4;
            
        

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
        else if (gameManager.GetComponent<GameManager>().hasFive == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[4];
            dieMoveNumber = 5;
            
            

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
        else if (gameManager.GetComponent<GameManager>().hasSix == true)
        {
            dieMoveIcon.GetComponent<Image>().sprite = numberSprites[5];
            dieMoveNumber = 6;
            
            energyButton.SetActive(false);

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

    }

    public void EnergyButtonIsclicked()
    {
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


    public void RightButtonIsClicked()
    {
        currentYAxis += 1;
        FindTargetLocation();
      
        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
    }

    public void LeftButtonIsClicked()
    {
        currentYAxis -= 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
    }

    public void UpButtonIsClicked()
    {
        currentXAxis -= 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
    }

    public void DownButtonIsClicked()
    {
        currentXAxis += 1;
        FindTargetLocation();

        StartCoroutine(MoveToTarget(neetle, targetLocation, speed));
    }

    IEnumerator MoveToTarget(GameObject neetle, GameObject targetLocation, float speedTranslation)
    {
        while (gameObject.transform.position != targetLocation.transform.position)
        {
            neetle.transform.position = Vector3.MoveTowards(neetle.transform.position, targetLocation.transform.position, speed * Time.deltaTime);
            yield return null;
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

        //turn on energy buttons only when have required energy

        if(gameManager.energyNumber >= 1)
        {
            energyButton.SetActive(true);
        }
        else
        {
            energyButton.SetActive(true);
        }

        if (gameManager.energyNumber >= 2)
        {
            doubleEnergyButton.SetActive(true);
        }
        else
        {
            doubleEnergyButton.SetActive(true);
        }

        //turn off move buttons when not usable
        if(currentYAxis == 4)
        {
            rightButton.SetActive(false);
        }
        else
        {
            rightButton.SetActive(true);
        }

        if(currentYAxis == 1)
        {
            leftButton.SetActive(false);
        }
        else
        {
            leftButton.SetActive(true);
        }

        if (currentXAxis == 1)
        {
            upButton.SetActive(false);
        }
        else
        {
            upButton.SetActive(true);
        }
        if (currentXAxis == 6)
        {
            downButton.SetActive(false);
        }
        else
        {
            downButton.SetActive(true);
        }
    }
}
