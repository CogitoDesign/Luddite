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

    private bool isOpen;


    public void NumberIsClicked()
    {

        buttonFour[0].GetComponent<Image>().color = new Color(0, 255, 0);

    }


    

    // Update is called once per frame
    //only 4 done so far for each loop makes all gameobjects active when hasNumber is true and all others off
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().hasOne == true)
        {
          
        }
        else if (gameManager.GetComponent<GameManager>().hasTwo == true)
        {
            
        }
        else if (gameManager.GetComponent<GameManager>().hasThree == true)
        {
            
        }
        else if (gameManager.GetComponent<GameManager>().hasFour == true)
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
        else if (gameManager.GetComponent<GameManager>().hasFive == true)
        {
          
        }
        else if (gameManager.GetComponent<GameManager>().hasSix == true)
        {
           
        }
 
    }
}
