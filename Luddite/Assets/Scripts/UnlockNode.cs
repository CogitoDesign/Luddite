using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class UnlockNode : MonoBehaviour
{
    
    public Material green;
    public Material purple;
    public Material red;

    public GameObject[] diceNodes;
    public GameObject[] bonusNodes;
    public GameObject[] toolNodes;

    public GameManager gameManager;

    public bool DieOnenode1IsUnlocked = false;
    public bool DieOnenode2IsUnlocked = false;
    public bool DieTwonode1IsUnlocked = false;
    public bool DieTwonode2IsUnlocked = false;
    public bool DieTwonode3IsUnlocked = false;
    public bool DieThreenode1IsUnlocked = false;
    public bool DieFournode1IsUnlocked = false;
    public bool DieFivenode1IsUnlocked = false;
    public bool DieFivenode2IsUnlocked = false;
    public bool DieSixnode1IsUnlocked = false;
    public bool DieSixnode2IsUnlocked = false;

    public bool DieOnenode1IsActive = false;
    public bool DieOnenode2IsActive = false;
    public bool DieTwonode1IsActive = false;
    public bool DieTwonode2IsActive = false;
    public bool DieTwonode3IsActive = false;
    public bool DieThreenode1IsActive = false;
    public bool DieFournode1IsActive = false;
    public bool DieFivenode1IsActive = false;
    public bool DieFivenode2IsActive = false;
    public bool DieSixnode1IsActive = false;
    public bool DieSixnode2IsActive = false;



    

    public void DieNodeOne1Clicked()
    {
       
       
        if (DieOnenode1IsActive == true && DieOnenode1IsUnlocked == false)
        {
            DieOnenode1IsUnlocked = true;
            diceNodes[0].GetComponent<MeshRenderer>().material = green;

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
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame check active die and turn dice nodes purple
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().hasSix == true)
        {
            if (DieSixnode1IsUnlocked == false)
            {
                diceNodes[9].GetComponent<MeshRenderer>().material = purple;
                DieSixnode1IsActive = true;
            }

            if (DieSixnode2IsUnlocked == false)
            {
                diceNodes[10].GetComponent<MeshRenderer>().material = purple;
                DieSixnode2IsActive = true;
            }

            // others back to red

            if (DieFivenode1IsUnlocked == false)
            {
                diceNodes[7].GetComponent<MeshRenderer>().material = red;
                DieFivenode1IsActive = false;
            }

            if (DieFivenode2IsUnlocked == false)
            {
                diceNodes[8].GetComponent<MeshRenderer>().material = red;
                DieFivenode2IsActive = false;
            }

            if (DieFournode1IsUnlocked == false)
            {
                diceNodes[6].GetComponent<MeshRenderer>().material = red;
                DieFournode1IsActive = false;
            }

            if (DieThreenode1IsUnlocked == false)
            {
                diceNodes[5].GetComponent<MeshRenderer>().material = red;
                DieThreenode1IsActive = false;
            }

            if (DieTwonode1IsUnlocked == false)
            {
                diceNodes[2].GetComponent<MeshRenderer>().material = red;
                DieTwonode1IsActive = false;
            }

            if (DieTwonode2IsUnlocked == false)
            {
                diceNodes[3].GetComponent<MeshRenderer>().material = red;
                DieTwonode2IsActive = false;
            }

            if (DieTwonode3IsUnlocked == false)
            {
                diceNodes[4].GetComponent<MeshRenderer>().material = red;
                DieTwonode3IsActive = false;
            }

            if (DieOnenode1IsUnlocked == false)
            {
                diceNodes[0].GetComponent<MeshRenderer>().material = red;
                DieOnenode1IsActive = false;
            }

            if (DieOnenode2IsUnlocked == false)
            {
                diceNodes[1].GetComponent<MeshRenderer>().material = red;
                DieOnenode2IsActive = false;
            }
        }

        else if (gameManager.GetComponent<GameManager>().hasFive == true)
        {
            if (DieFivenode1IsUnlocked == false)
            {
                diceNodes[7].GetComponent<MeshRenderer>().material = purple;
                DieFivenode1IsActive = true;
            }

            if (DieFivenode2IsUnlocked == false)
            {
                diceNodes[8].GetComponent<MeshRenderer>().material = purple;
                DieFivenode2IsActive = true;
            }

            // others back to red

            if (DieSixnode1IsUnlocked == false)
            {
                diceNodes[9].GetComponent<MeshRenderer>().material = red;
                DieSixnode1IsActive = false;
            }

            if (DieSixnode2IsUnlocked == false)
            {
                diceNodes[10].GetComponent<MeshRenderer>().material = red;
                DieSixnode2IsActive = false;
            }

            if (DieFournode1IsUnlocked == false)
            {
                diceNodes[6].GetComponent<MeshRenderer>().material = red;
                DieFournode1IsActive = false;
            }

            if (DieThreenode1IsUnlocked == false)
            {
                diceNodes[5].GetComponent<MeshRenderer>().material = red;
                DieThreenode1IsActive = false;
            }

            if (DieTwonode1IsUnlocked == false)
            {
                diceNodes[2].GetComponent<MeshRenderer>().material = red;
                DieTwonode1IsActive = false;
            }

            if (DieTwonode2IsUnlocked == false)
            {
                diceNodes[3].GetComponent<MeshRenderer>().material = red;
                DieTwonode2IsActive = false;
            }

            if (DieTwonode3IsUnlocked == false)
            {
                diceNodes[4].GetComponent<MeshRenderer>().material = red;
                DieTwonode3IsActive = false;
            }

            if (DieOnenode1IsUnlocked == false)
            {
                diceNodes[0].GetComponent<MeshRenderer>().material = red;
                DieOnenode1IsActive = false;
            }

            if (DieOnenode2IsUnlocked == false)
            {
                diceNodes[1].GetComponent<MeshRenderer>().material = red;
                DieOnenode2IsActive = false;
            }

        }

        else if (gameManager.GetComponent<GameManager>().hasFour == true)
        {
            if (DieFournode1IsUnlocked == false)
            {
                diceNodes[6].GetComponent<MeshRenderer>().material = purple;
                DieFournode1IsActive = true;
            }

            // others back to red

            if (DieSixnode1IsUnlocked == false)
            {
                diceNodes[9].GetComponent<MeshRenderer>().material = red;
                DieSixnode1IsActive = false;
            }

            if (DieSixnode2IsUnlocked == false)
            {
                diceNodes[10].GetComponent<MeshRenderer>().material = red;
                DieSixnode2IsActive = false;
            }

            if (DieThreenode1IsUnlocked == false)
            {
                diceNodes[5].GetComponent<MeshRenderer>().material = red;
                DieThreenode1IsActive = false;
            }

            if (DieTwonode1IsUnlocked == false)
            {
                diceNodes[2].GetComponent<MeshRenderer>().material = red;
                DieTwonode1IsActive = false;
            }

            if (DieTwonode2IsUnlocked == false)
            {
                diceNodes[3].GetComponent<MeshRenderer>().material = red;
                DieTwonode2IsActive = false;
            }

            if (DieTwonode3IsUnlocked == false)
            {
                diceNodes[4].GetComponent<MeshRenderer>().material = red;
                DieTwonode3IsActive = false;
            }

            if (DieOnenode1IsUnlocked == false)
            {
                diceNodes[0].GetComponent<MeshRenderer>().material = red;
                DieOnenode1IsActive = false;
            }

            if (DieOnenode2IsUnlocked == false)
            {
                diceNodes[1].GetComponent<MeshRenderer>().material = red;
                DieOnenode2IsActive = false;
            }

            if (DieFivenode1IsUnlocked == false)
            {
                diceNodes[7].GetComponent<MeshRenderer>().material = red;
                DieFivenode1IsActive = false;
            }

            if (DieFivenode2IsUnlocked == false)
            {
                diceNodes[8].GetComponent<MeshRenderer>().material = red;
                DieFivenode2IsActive = false;
            }

        }

        else if (gameManager.GetComponent<GameManager>().hasThree == true)
        {
            if (DieThreenode1IsUnlocked == false)
            {
                diceNodes[5].GetComponent<MeshRenderer>().material = purple;
                DieThreenode1IsActive = true;
            }

            // others back to red

            if (DieSixnode1IsUnlocked == false)
            {
                diceNodes[9].GetComponent<MeshRenderer>().material = red;
                DieSixnode1IsActive = false;
            }

            if (DieSixnode2IsUnlocked == false)
            {
                diceNodes[10].GetComponent<MeshRenderer>().material = red;
                DieSixnode2IsActive = false;
            }

            if (DieTwonode1IsUnlocked == false)
            {
                diceNodes[2].GetComponent<MeshRenderer>().material = red;
                DieTwonode1IsActive = false;
            }

            if (DieTwonode2IsUnlocked == false)
            {
                diceNodes[3].GetComponent<MeshRenderer>().material = red;
                DieTwonode2IsActive = false;
            }

            if (DieTwonode3IsUnlocked == false)
            {
                diceNodes[4].GetComponent<MeshRenderer>().material = red;
                DieTwonode3IsActive = false;
            }

            if (DieOnenode1IsUnlocked == false)
            {
                diceNodes[0].GetComponent<MeshRenderer>().material = red;
                DieOnenode1IsActive = false;
            }

            if (DieOnenode2IsUnlocked == false)
            {
                diceNodes[1].GetComponent<MeshRenderer>().material = red;
                DieOnenode2IsActive = false;
            }

            if (DieFivenode1IsUnlocked == false)
            {
                diceNodes[7].GetComponent<MeshRenderer>().material = red;
                DieFivenode1IsActive = false;
            }

            if (DieFivenode2IsUnlocked == false)
            {
                diceNodes[8].GetComponent<MeshRenderer>().material = red;
                DieFivenode2IsActive = false;
            }

            if (DieFournode1IsUnlocked == false)
            {
                diceNodes[6].GetComponent<MeshRenderer>().material = red;
                DieFournode1IsActive = false;
            }

        }

        else if (gameManager.GetComponent<GameManager>().hasTwo == true)
        {
            if (DieTwonode1IsUnlocked == false)
            {
                diceNodes[2].GetComponent<MeshRenderer>().material = purple;
                DieTwonode1IsActive = true;
            }

            if (DieTwonode2IsUnlocked == false)
            {
                diceNodes[3].GetComponent<MeshRenderer>().material = purple;
                DieTwonode2IsActive = true;
            }

            if (DieTwonode3IsUnlocked == false)
            {
                diceNodes[4].GetComponent<MeshRenderer>().material = purple;
                DieTwonode3IsActive = true;
            }

            // others back to red

            if (DieSixnode1IsUnlocked == false)
            {
                diceNodes[9].GetComponent<MeshRenderer>().material = red;
                DieSixnode1IsActive = false;
            }

            if (DieSixnode2IsUnlocked == false)
            {
                diceNodes[10].GetComponent<MeshRenderer>().material = red;
                DieSixnode2IsActive = false;
            }

            if (DieOnenode1IsUnlocked == false)
            {
                diceNodes[0].GetComponent<MeshRenderer>().material = red;
                DieOnenode1IsActive = false;
            }

            if (DieOnenode2IsUnlocked == false)
            {
                diceNodes[1].GetComponent<MeshRenderer>().material = red;
                DieOnenode2IsActive = false;
            }

            if (DieFivenode1IsUnlocked == false)
            {
                diceNodes[7].GetComponent<MeshRenderer>().material = red;
                DieFivenode1IsActive = false;
            }

            if (DieFivenode2IsUnlocked == false)
            {
                diceNodes[8].GetComponent<MeshRenderer>().material = red;
                DieFivenode2IsActive = false;
            }

            if (DieFournode1IsUnlocked == false)
            {
                diceNodes[6].GetComponent<MeshRenderer>().material = red;
                DieFournode1IsActive = false;
            }

            if (DieThreenode1IsUnlocked == false)
            {
                diceNodes[5].GetComponent<MeshRenderer>().material = red;
                DieThreenode1IsActive = false;
            }
        }

        else if (gameManager.GetComponent<GameManager>().hasOne == true)
        {
            if (DieOnenode1IsUnlocked == false)
            {
                diceNodes[0].GetComponent<MeshRenderer>().material = purple;
                DieOnenode1IsActive = true;
            }

            if (DieOnenode2IsUnlocked == false)
            {
                diceNodes[1].GetComponent<MeshRenderer>().material = purple;
                DieOnenode2IsActive = true;
            }

            // others back to red

            if (DieSixnode1IsUnlocked == false)
            {
                diceNodes[9].GetComponent<MeshRenderer>().material = red;
                DieSixnode1IsActive = false;
            }

            if (DieSixnode2IsUnlocked == false)
            {
                diceNodes[10].GetComponent<MeshRenderer>().material = red;
                DieSixnode2IsActive = false;
            }

            if (DieFivenode1IsUnlocked == false)
            {
                diceNodes[7].GetComponent<MeshRenderer>().material = red;
                DieFivenode1IsActive = false;
            }

            if (DieFivenode2IsUnlocked == false)
            {
                diceNodes[8].GetComponent<MeshRenderer>().material = red;
                DieFivenode2IsActive = false;
            }

            if (DieFournode1IsUnlocked == false)
            {
                diceNodes[6].GetComponent<MeshRenderer>().material = red;
                DieFournode1IsActive = false;
            }

            if (DieThreenode1IsUnlocked == false)
            {
                diceNodes[5].GetComponent<MeshRenderer>().material = red;
                DieThreenode1IsActive = false;
            }

            if (DieTwonode1IsUnlocked == false)
            {
                diceNodes[2].GetComponent<MeshRenderer>().material = red;
                DieTwonode1IsActive = false;
            }

            if (DieTwonode2IsUnlocked == false)
            {
                diceNodes[3].GetComponent<MeshRenderer>().material = red;
                DieTwonode2IsActive = false;
            }

            if (DieTwonode3IsUnlocked == false)
            {
                diceNodes[4].GetComponent<MeshRenderer>().material = red;
                DieTwonode3IsActive = false;
            }

        }

        else if (gameManager.GetComponent<GameManager>().hasOne == false && gameManager.GetComponent<GameManager>().hasTwo == false && gameManager.GetComponent<GameManager>().hasThree == false && gameManager.GetComponent<GameManager>().hasFour == false && gameManager.GetComponent<GameManager>().hasFive == false && gameManager.GetComponent<GameManager>().hasSix == false)
        {
            if (DieOnenode1IsUnlocked == false)
            {
                diceNodes[0].GetComponent<MeshRenderer>().material = red;
                DieOnenode1IsActive = false;
            }

            if (DieOnenode2IsUnlocked == false)
            {
                diceNodes[1].GetComponent<MeshRenderer>().material = red;
                DieOnenode2IsActive = false;
            }

            // others back to red

            if (DieSixnode1IsUnlocked == false)
            {
                diceNodes[9].GetComponent<MeshRenderer>().material = red;
                DieSixnode1IsActive = false;
            }

            if (DieSixnode2IsUnlocked == false)
            {
                diceNodes[10].GetComponent<MeshRenderer>().material = red;
                DieSixnode2IsActive = false;
            }

            if (DieFivenode1IsUnlocked == false)
            {
                diceNodes[7].GetComponent<MeshRenderer>().material = red;
                DieFivenode1IsActive = false;
            }

            if (DieFivenode2IsUnlocked == false)
            {
                diceNodes[8].GetComponent<MeshRenderer>().material = red;
                DieFivenode2IsActive = false;
            }

            if (DieFournode1IsUnlocked == false)
            {
                diceNodes[6].GetComponent<MeshRenderer>().material = red;
                DieFournode1IsActive = false;
            }

            if (DieThreenode1IsUnlocked == false)
            {
                diceNodes[5].GetComponent<MeshRenderer>().material = red;
                DieThreenode1IsActive = false;
            }

            if (DieTwonode1IsUnlocked == false)
            {
                diceNodes[2].GetComponent<MeshRenderer>().material = red;
                DieTwonode1IsActive = false;
            }

            if (DieTwonode2IsUnlocked == false)
            {
                diceNodes[3].GetComponent<MeshRenderer>().material = red;
                DieTwonode2IsActive = false;
            }

            if (DieTwonode3IsUnlocked == false)
            {
                diceNodes[4].GetComponent<MeshRenderer>().material = red;
                DieTwonode3IsActive = false;
            }

        }
    }
}
