using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnergyNode2 : MonoBehaviour
{
    public UnlockNode unlockNode;
    public GameManager gameManager;
    public AudioSource dieNodeUnlock;

    public ScreensAppear screensAppear;

    public bool nodeIsUnlocked;
    public bool nodeIsPurple;

    public Material green;
    public Material purple;
    public Material red;

    public AudioSource sparks;
    public ParticleSystem sparksEffect;



    // Start is called before the first frame update
    void Start()
    {
        nodeIsUnlocked = false;
    }


    public void OnMouseDown()
    {
        if (screensAppear.switchesScreen.activeSelf == true || screensAppear.clockScreen.activeSelf == true || screensAppear.hackScreen.activeSelf == true || screensAppear.rollbonusScreen.activeSelf == true || screensAppear.toolsScreen.activeSelf == true || screensAppear.moveOptionsScreen.activeSelf == true)
        {
        }
        else
        {

            if (nodeIsPurple == true)
            {

                GetComponent<MeshRenderer>().material = green;
                dieNodeUnlock.Play();
                sparksEffect.Play();
                sparks.Play();
                gameManager.energyNumber -= 1;
                nodeIsPurple = false;
                nodeIsUnlocked = true;

            }
        }
    }

    void Update()
    {

        //check if energynode is open
        if (gameManager.energyNumber > 0 && nodeIsUnlocked == false)
        {
            GetComponent<MeshRenderer>().material = purple;
            nodeIsPurple = true;
        }
        else if (gameManager.energyNumber == 0 && nodeIsUnlocked == false)
        {
            GetComponent<MeshRenderer>().material = red;
            nodeIsPurple = false;
        }
        else
        {

        }

    }

}
