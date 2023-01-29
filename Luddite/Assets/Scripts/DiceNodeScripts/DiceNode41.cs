using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceNode41 : MonoBehaviour
{
    public UnlockNode unlockNode;
    public GameManager gameManager;

    public Material green;
    public Material purple;
    public Material red;

    public void OnMouseDown()
    {
        if (unlockNode.DieFournode1IsActive == true && unlockNode.DieFournode1IsUnlocked == false)
        {
            unlockNode.DieFournode1IsUnlocked = true;
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
