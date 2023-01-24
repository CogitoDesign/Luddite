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


    public GameManager gameManager;

    public bool nodeIsUnlocked = false;
    private bool nodeIsActive = false;

    
    //click on green node
    public void OnMouseDown()
    {
        if(nodeIsActive == true)
        {
            nodeIsUnlocked = true;
            changeMaterialToGreen();
            nodeIsActive = false;

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

    //material changes

    public void changeMaterialToGreen()
    {
        gameObject.GetComponent<MeshRenderer>().material = green;
    }

    public void changeMaterialToPurple()
    {
        gameObject.GetComponent<MeshRenderer>().material = purple;
    }

    public void changeMaterialToRed()
    {
        gameObject.GetComponent<MeshRenderer>().material = red;
    }

    //checknodes based on active die

    public void NodeCheck()
    {
        
        if (gameManager.GetComponent<GameManager>().hasSix == true && gameObject.tag == "6Unlocked" && nodeIsUnlocked == false)
        {
            changeMaterialToPurple();
            nodeIsActive = true;
        }


        if (gameManager.GetComponent<GameManager>().hasFive == true && gameObject.tag == "5Unlocked" && nodeIsUnlocked == false)
        {
            changeMaterialToPurple();
            nodeIsActive = true;
        }

        if (gameManager.GetComponent<GameManager>().hasFour == true && gameObject.tag == "4Unlocked" && nodeIsUnlocked == false)
        {
            changeMaterialToPurple();
            nodeIsActive = true;
        }

        if (gameManager.GetComponent<GameManager>().hasThree == true && gameObject.tag == "3Unlocked" && nodeIsUnlocked == false)
        {
            changeMaterialToPurple();
            nodeIsActive = true;
        }

        if (gameManager.GetComponent<GameManager>().hasTwo == true && gameObject.tag == "2Unlocked" && nodeIsUnlocked == false)
        {
            changeMaterialToPurple();
            nodeIsActive = true;
        }

        if (gameManager.GetComponent<GameManager>().hasOne == true && gameObject.tag == "1Unlocked" && nodeIsUnlocked == false)
        {
            changeMaterialToPurple();
            nodeIsActive = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
