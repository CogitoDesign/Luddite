using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ScreensAppear : MonoBehaviour
{

    //buttons
    public GameObject switchesScreen;
    public GameObject clockScreen;
    public GameObject hackScreen;
    public GameObject rollbonusScreen;
    public GameObject toolsScreen;
    public GameObject moveOptionsScreen;

    public IEnumerator startVideo;

    

    public GameObject videoImage;

    public AudioSource backgroundMusic;

    public GameManager gameManager;

    public VideoPlayer howToPlayVideoPlayer;
    public VideoPlayer endGameVideoPlayer;
    public VideoPlayer startGameVideoPlayer;

    public GameObject blankScreen;

    public void Start()
    {
        startVideo = StartVideo();

        //REMOVE // in line below to put in video at the start of game

        if (gameManager.levelOneIsActive)
        {
            StartCoroutine(startVideo);
        }
        if (gameManager.levelTwoIsActive)
        {
            StartCoroutine(startVideo);
        }
        if (gameManager.levelThreeIsActive)
        {
            StartCoroutine(startVideo);
        }
        if (gameManager.levelSevenIsActive)
        {
            StartCoroutine(startVideo);
        }


    }

    IEnumerator StartVideo()
    {
        
        startGameVideoPlayer.Play();
        if (gameManager.levelOneIsActive)
        {
            yield return new WaitForSeconds(744.0f);
        }
        else if (gameManager.levelTwoIsActive)
        {
            yield return new WaitForSeconds(234.0f);
        }
        else if (gameManager.levelThreeIsActive)
        {
            yield return new WaitForSeconds(434.0f);
        }
        else if (gameManager.levelSevenIsActive)
        {
            yield return new WaitForSeconds(333.0f);
        }
        blankScreen.SetActive(false);
        Debug.Log("start video done");
        videoImage.SetActive(false);
        backgroundMusic.volume = 1;
        backgroundMusic.Play();
    }

    public void playVideo()
    {
        //REMOVE ALL // TO PUT IN VIDEO
        videoImage.SetActive(true);
        backgroundMusic.volume = 0;
        
        howToPlayVideoPlayer.Play();
    }

    public void CloseVideo()
    {
        
        StopCoroutine(startVideo);
        blankScreen.SetActive(false);
        videoImage.SetActive(false);
        howToPlayVideoPlayer.Stop();
        startGameVideoPlayer.Stop();
        backgroundMusic.volume = 1;
        backgroundMusic.Play();

        

    }

    public void CloseEndGameVideo()
    {
        
        videoImage.SetActive(false);
      
        gameManager.closeFinalVidbool = true;
        endGameVideoPlayer.Stop();
        backgroundMusic.volume = 1;
        backgroundMusic.Play();
    }


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

    public void MainMenuIsClicked()
    {
        SceneManager.LoadScene("MenuScreen");
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
