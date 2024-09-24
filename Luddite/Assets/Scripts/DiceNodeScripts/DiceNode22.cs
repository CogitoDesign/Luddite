using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceNode22 : MonoBehaviour
{
    public UnlockNode unlockNode;
    public GameManager gameManager;
    public AudioSource dieNodeUnlock;

    public ScreensAppear screensAppear;

    public Material green;
    public Material purple;
    public Material red;

    public AudioSource sparks;
    public ParticleSystem sparksEffect;

    public void OnMouseDown()
    {
        if (screensAppear.switchesScreen.activeSelf == true || screensAppear.clockScreen.activeSelf == true || screensAppear.hackScreen.activeSelf == true || screensAppear.rollbonusScreen.activeSelf == true || screensAppear.toolsScreen.activeSelf == true || screensAppear.moveOptionsScreen.activeSelf == true)
        {
        }
        else
        {
            if (gameManager.mustUseClock == false)
            {
                if (unlockNode.DieTwonode2IsActive == true && unlockNode.DieTwonode2IsUnlocked == false)
                {
                    unlockNode.DieTwonode2IsUnlocked = true;
                    gameObject.GetComponent<MeshRenderer>().material = green;
                    dieNodeUnlock.Play();
                    sparksEffect.Play();
                    sparks.Play();

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
    }
}
