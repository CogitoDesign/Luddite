using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreensAppear : MonoBehaviour
{

    //buttons
    public GameObject switchesScreen;
    public GameObject clockScreen;
    public GameObject hackScreen;
    public GameObject rollbonusScreen;
    public GameObject toolsScreen;
    public GameObject moveOptionsScreen;

  


    public GameManager gameManager;

    //close all menus
    public void CloseAllMenus()
    {
        switchesScreen.SetActive(false);
        clockScreen.SetActive(false);
        hackScreen.SetActive(false);
        rollbonusScreen.SetActive(false);
        toolsScreen.SetActive(false);
        moveOptionsScreen.SetActive(false);
    }


    //turn on and off switch menu and turn off all other menus
    public void SwitchMenuIsOn()
    {
        gameManager.select.Play();
        if (switchesScreen.activeSelf == false)
        {
            switchesScreen.SetActive(true);
            
            clockScreen.SetActive(false);
            hackScreen.SetActive(false);
            rollbonusScreen.SetActive(false);
            toolsScreen.SetActive(false);
            moveOptionsScreen.SetActive(false);
            
        }
        else
        {
            switchesScreen.SetActive(false);
           
        }

    }

    //turn on and off clock menu and turn off all other menus
    public void ClockMenuIsOn()
    {
        gameManager.select.Play();
        if (clockScreen.activeSelf == false)
        {
            clockScreen.SetActive(true);
         
            switchesScreen.SetActive(false);
            hackScreen.SetActive(false);
            rollbonusScreen.SetActive(false);
            toolsScreen.SetActive(false);
            moveOptionsScreen.SetActive(false);
         
        }
        else
        {
            clockScreen.SetActive(false);
           
        }

    }

    //turn on and off hack menu and turn off all other menus
    public void HackMenuIsOn()
    {
        gameManager.select.Play();
        if (hackScreen.activeSelf == false)
        {
            hackScreen.SetActive(true);
           
            switchesScreen.SetActive(false);
            clockScreen.SetActive(false);
            rollbonusScreen.SetActive(false);
            toolsScreen.SetActive(false);
            moveOptionsScreen.SetActive(false);
        
        }
        else
        {
            hackScreen.SetActive(false);
    
        }

    }

    public void RollbonusMenuIsOn()
    {
        gameManager.select.Play();
        if (rollbonusScreen.activeSelf == false)
        {
            rollbonusScreen.SetActive(true);
 
            clockScreen.SetActive(false);
            hackScreen.SetActive(false);
            switchesScreen.SetActive(false);
            toolsScreen.SetActive(false);
            moveOptionsScreen.SetActive(false);
         

        }
        else
        {
            rollbonusScreen.SetActive(false);
        
        }

    }

    public void ToolsMenuIsOn()
    {
        gameManager.select.Play();
        if (toolsScreen.activeSelf == false)
        {
            rollbonusScreen.SetActive(false);
            clockScreen.SetActive(false);
            hackScreen.SetActive(false);
            switchesScreen.SetActive(false);
            toolsScreen.SetActive(true);
     
            moveOptionsScreen.SetActive(false);
           
        }
        else
        {
            toolsScreen.SetActive(false);
       
        }

    }

    public void MoveOptionsMenuIsOn()
    {
        gameManager.select.Play();
        if (moveOptionsScreen.activeSelf == false)
        {
            moveOptionsScreen.SetActive(true);
    
            rollbonusScreen.SetActive(false);
            clockScreen.SetActive(false);
            hackScreen.SetActive(false);
            switchesScreen.SetActive(false);
            toolsScreen.SetActive(false);
         
        }
        else
        {
            moveOptionsScreen.SetActive(false);
     
        }

    }
/*
    public void TurnClockScreenOnOnNewRound()
    {

        if (clockScreen.activeSelf == false)
        {
            clockScreen.SetActive(true);
       
            switchesScreen.SetActive(false);
            hackScreen.SetActive(false);
            rollbonusScreen.SetActive(false);
            toolsScreen.SetActive(false);
            moveOptionsScreen.SetActive(false);
     
        }
        else
        {
        }
    }
*/

}
