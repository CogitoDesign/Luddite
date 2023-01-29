using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceNode21 : MonoBehaviour
{
    public UnlockNode unlockNode;
    public GameManager gameManager;

    public Material green;
    public Material purple;
    public Material red;

    public void OnMouseDown()
    {
        if (unlockNode.DieTwonode1IsActive == true && unlockNode.DieTwonode1IsUnlocked == false)
        {
            unlockNode.DieTwonode1IsUnlocked = true;
            gameObject.GetComponent<MeshRenderer>().material = green;

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
}
