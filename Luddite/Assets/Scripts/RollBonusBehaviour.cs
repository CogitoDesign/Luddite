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

    public AudioSource bonusSFX;

    public GameManager gameManager;

    public void ButtonOne1isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box1[0].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.creditNumber += 1;
            crosses[0].SetActive(true);
            box1[0].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonOne2isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
        box1[1].GetComponent<Image>().color = new Color(0, 255, 0);
        gameManager.creditNumber += 1;
        crosses[1].SetActive(true);
        box1[1].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonOne3isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box1[2].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.creditNumber += 1;
            crosses[2].SetActive(true);
            box1[2].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }

    }

    public void ButtonOne4isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box1[3].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.energyNumber += 2;
            crosses[8].SetActive(true);
            box1[3].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonOne5isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            gameManager.damageSFX.Play();
            box1[4].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.damageNumber += 2;
            gameManager.rollbonusDamage += 2;
            crosses[12].SetActive(true);
            box1[4].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonTwo1isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box2[0].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.multitoolNumber += 2;
            crosses[4].SetActive(true);
            box2[0].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }

    }

    public void ButtonTwo2isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box2[1].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.energyNumber += 2;
            crosses[9].SetActive(true);
            box2[1].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonTwo3isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            gameManager.damageSFX.Play();
            box2[2].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.damageNumber += 2;
            gameManager.rollbonusDamage += 2;
            crosses[14].SetActive(true);
            box2[2].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonThree1isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box3[0].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.multitoolNumber += 2;
            crosses[5].SetActive(true);
            box3[0].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonThree2isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            gameManager.damageSFX.Play();
            box3[1].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.damageNumber += 2;
            gameManager.rollbonusDamage += 2;
            crosses[15].SetActive(true);
            box3[1].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonFour1isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box4[0].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.energyNumber += 2;
            crosses[10].SetActive(true);
            box4[0].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonFour2isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            gameManager.damageSFX.Play();
            box4[1].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.damageNumber += 2;
            gameManager.rollbonusDamage += 2;
            crosses[16].SetActive(true);
            box4[1].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonFive1isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box5[0].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.multitoolNumber += 2;
            crosses[6].SetActive(true);
            box5[0].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }

    }

    public void ButtonFive2isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            gameManager.damageSFX.Play();
            box5[1].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.damageNumber += 2;
            gameManager.rollbonusDamage += 2;
            crosses[17].SetActive(true);
            box5[1].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonSix1isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box6[0].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.creditNumber += 1;
            crosses[3].SetActive(true);
            box6[0].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }

    public void ButtonSix2isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box6[1].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.multitoolNumber += 2;
            crosses[7].SetActive(true);
            box6[1].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }


    public void ButtonSix3isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            bonusSFX.Play();
            box6[2].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.energyNumber += 2;
            crosses[11].SetActive(true);
            box6[2].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
        }
    }


    public void ButtonSix4isClicked()
    {
        if (gameManager.mustUseClock == false)
        {
            gameManager.damageSFX.Play();
            box6[3].GetComponent<Image>().color = new Color(0, 255, 0);
            gameManager.damageNumber += 2;
            gameManager.rollbonusDamage += 2;
            crosses[13].SetActive(true);
            box6[3].GetComponent<Button>().interactable = false;

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
        else
        {
            gameManager.ClockErrorScreen();
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
