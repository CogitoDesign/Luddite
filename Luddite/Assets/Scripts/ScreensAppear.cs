using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreensAppear : MonoBehaviour
{

    //buttons
    public GameObject switchesScreen;
    public GameObject clockScreen;


    //turn on and off switch menu and turn off all other menus
    public void SwitchMenuIsOn()
    {
        
        if (switchesScreen.activeSelf == false)
        {
            switchesScreen.SetActive(true);
            clockScreen.SetActive(false);
        }
        else
        {
            switchesScreen.SetActive(false);
        }

    }

    //turn on and off clock menu and turn off all other menus
    public void ClockMenuIsOn()
    {

        if (clockScreen.activeSelf == false)
        {
            clockScreen.SetActive(true);
            switchesScreen.SetActive(false);
        }
        else
        {
            clockScreen.SetActive(false);
        }

    }


}
