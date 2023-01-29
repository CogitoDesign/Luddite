using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class RollBonusBehaviour : MonoBehaviour
{
    public GameObject[] crosses;

    public GameObject[] box1;
    public GameObject[] box2;
    public GameObject[] box3;
    public GameObject[] box4;
    public GameObject[] box5;
    public GameObject[] box6;

    public GameManager gameManager;

    public void ButtonOne1isClicked()
    {
        box1[0].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.creditNumber += 1;
        crosses[0].SetActive(true);
        box1[0].GetComponent<Button>().interactable = false;

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

    public void ButtonOne2isClicked()
    {
        box1[1].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.creditNumber += 1;
        crosses[1].SetActive(true);
        box1[1].GetComponent<Button>().interactable = false;

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

    public void ButtonOne3isClicked()
    {
        box1[2].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.creditNumber += 1;
        crosses[2].SetActive(true);
        box1[2].GetComponent<Button>().interactable = false;

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

    public void ButtonOne4isClicked()
    {
        box1[3].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.energyNumber += 2;
        crosses[8].SetActive(true);
        box1[3].GetComponent<Button>().interactable = false;

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

    public void ButtonOne5isClicked()
    {
        box1[4].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.damageNumber += 2;
        crosses[12].SetActive(true);
        box1[4].GetComponent<Button>().interactable = false;

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

    public void ButtonTwo1isClicked()
    {
        box2[0].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.multitoolNumber += 2;
        crosses[4].SetActive(true);
        box2[0].GetComponent<Button>().interactable = false;

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

    public void ButtonTwo2isClicked()
    {
        box2[1].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.energyNumber += 2;
        crosses[9].SetActive(true);
        box2[1].GetComponent<Button>().interactable = false;

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

    public void ButtonTwo3isClicked()
    {
        box2[2].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.damageNumber += 2;
        crosses[14].SetActive(true);
        box2[2].GetComponent<Button>().interactable = false;

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

    public void ButtonThree1isClicked()
    {
        box3[0].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.multitoolNumber += 2;
        crosses[5].SetActive(true);
        box3[0].GetComponent<Button>().interactable = false;

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

    public void ButtonThree2isClicked()
    {
        box3[1].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.damageNumber += 2;
        crosses[15].SetActive(true);
        box3[1].GetComponent<Button>().interactable = false;

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

    public void ButtonFour1isClicked()
    {
        box4[0].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.energyNumber += 2;
        crosses[10].SetActive(true);
        box4[0].GetComponent<Button>().interactable = false;

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

    public void ButtonFour2isClicked()
    {
        box4[1].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.damageNumber += 2;
        crosses[16].SetActive(true);
        box4[1].GetComponent<Button>().interactable = false;

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

    public void ButtonFive1isClicked()
    {
        box5[0].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.multitoolNumber += 2;
        crosses[6].SetActive(true);
        box5[0].GetComponent<Button>().interactable = false;

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

    public void ButtonFive2isClicked()
    {
        box5[1].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.damageNumber += 2;
        crosses[17].SetActive(true);
        box5[1].GetComponent<Button>().interactable = false;

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

    public void ButtonSix1isClicked()
    {
        box6[0].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.creditNumber += 1;
        crosses[3].SetActive(true);
        box6[0].GetComponent<Button>().interactable = false;

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

    public void ButtonSix2isClicked()
    {
        box6[1].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.multitoolNumber += 2;
        crosses[7].SetActive(true);
        box6[1].GetComponent<Button>().interactable = false;

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


    public void ButtonSix3isClicked()
    {
        box6[2].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.energyNumber += 2;
        crosses[11].SetActive(true);
        box6[2].GetComponent<Button>().interactable = false;

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


    public void ButtonSix4isClicked()
    {
        box6[3].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.damageNumber += 2;
        crosses[13].SetActive(true);
        box6[3].GetComponent<Button>().interactable = false;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //turn on relevant roll bonus buttons based on active die

        if (gameManager.GetComponent<GameManager>().hasOne == true)
        {
            foreach (GameObject box in box1)
            {
                box.SetActive(true);
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
                box.SetActive(false);
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
        else if (gameManager.GetComponent<GameManager>().hasTwo == true)
        {
            foreach (GameObject box in box1)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box2)
            {
                box.SetActive(true);
            }

            foreach (GameObject box in box3)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box4)
            {
                box.SetActive(false);
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
        else if (gameManager.GetComponent<GameManager>().hasThree == true)
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
                box.SetActive(true);
            }

            foreach (GameObject box in box4)
            {
                box.SetActive(false);
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
                box.SetActive(false);
            }

            foreach (GameObject box in box5)
            {
                box.SetActive(true);
            }

            foreach (GameObject box in box6)
            {
                box.SetActive(false);
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasSix == true)
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
                box.SetActive(false);
            }

            foreach (GameObject box in box5)
            {
                box.SetActive(false);
            }

            foreach (GameObject box in box6)
            {
                box.SetActive(true);
            }
        }
        else if (gameManager.GetComponent<GameManager>().hasOne == false && gameManager.GetComponent<GameManager>().hasTwo == false && gameManager.GetComponent<GameManager>().hasThree == false && gameManager.GetComponent<GameManager>().hasFour == false && gameManager.GetComponent<GameManager>().hasFive == false && gameManager.GetComponent<GameManager>().hasSix == false)
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
                box.SetActive(false);
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

    }
}
