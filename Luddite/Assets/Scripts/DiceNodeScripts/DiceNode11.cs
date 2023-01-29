using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiceNode11 : MonoBehaviour
{
    public UnlockNode unlockNode;
    public GameManager gameManager;

    public Material green;
    public Material purple;
    public Material red;

    public void OnMouseDown()
    {
       
        if (unlockNode.DieOnenode1IsActive == true && unlockNode.DieOnenode1IsUnlocked == false)
        {
            unlockNode.DieOnenode1IsUnlocked = true;
            unlockNode.diceNodes[0].GetComponent<MeshRenderer>().material = green;

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
