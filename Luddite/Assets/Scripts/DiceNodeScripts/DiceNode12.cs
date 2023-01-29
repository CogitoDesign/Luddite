using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiceNode12 : MonoBehaviour
{
    public UnlockNode unlockNode;
    public GameManager gameManager;

    public Material green;
    public Material purple;
    public Material red;

    public void OnMouseDown()
    {
        if (unlockNode.DieOnenode2IsActive == true && unlockNode.DieOnenode2IsUnlocked == false)
        {
            unlockNode.DieOnenode2IsUnlocked = true;
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
