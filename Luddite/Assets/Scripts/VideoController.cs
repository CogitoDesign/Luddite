using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public VideoPlayer howToPlayVideoPlayer;
    public VideoPlayer endGameVideoPlayer;
    //public Slider progressBar;      // Reference to the progress bar
    public float rewindSpeed = 10f; // Speed for rewinding
    public float forwardSpeed = 10f; // Speed for fast-forwarding
    public GameObject videoPanel;   // The UI panel showing the video player
    public CanvasGroup uiCanvasGroup; // CanvasGroup for fading UI buttons
    public float fadeDuration = 1f;  // Duration for fade in/out
    public float inactivityTime = 2f; // Time to wait before fading out the UI
    public GameObject pauseButton;
    public GameObject playButton;

    private bool isPaused = false;
    private float lastMouseMovementTime = 0f;
    private Vector3 lastMousePosition;
    private bool isUIVisible = true;

    public ScreensAppear screensAppear;
    public GameManager gameManager;
    public Clock clock;


    void Start()
    {
        
        // Initialize the progress bar
        //progressBar.minValue = 0;
        //progressBar.maxValue = (float)videoPlayer.length;
        //progressBar.onValueChanged.AddListener(ScrubVideo);

        videoPlayer.loopPointReached += EndReached;
        howToPlayVideoPlayer.loopPointReached += EndReached;
        endGameVideoPlayer.loopPointReached += EndReached;

        


        // Store initial mouse position to detect changes
        lastMousePosition = Input.mousePosition;


        if (gameManager.levelOneIsActive)
        {
            videoPlayer.Play();
        }
        if (gameManager.levelTwoIsActive)
        {
            videoPlayer.Play();
        }
        if (gameManager.levelThreeIsActive)
        {
            videoPlayer.Play();
        }
        if (gameManager.levelSevenIsActive)
        {
            videoPlayer.Play();
        }
    }
    
    void Update()
    {
        // Update progress bar during video playback
        //if (videoPlayer.isPlaying)
        //{
        //    progressBar.value = (float)videoPlayer.time;
        //}

        // Check for mouse movement
        if (Input.mousePosition != lastMousePosition)
        {
            lastMouseMovementTime = Time.time; // Reset timer on mouse movement
            lastMousePosition = Input.mousePosition;

            if (!isUIVisible)
            {
                ShowUI();
            }
        }

        // Fade out UI if there's no mouse movement for a couple of seconds
        if (Time.time - lastMouseMovementTime > inactivityTime && isUIVisible)
        {
            HideUI();
        }

       
            // Update progress bar during video playback
         //   if (videoPlayer.isPlaying)
         //   {
         //       progressBar.value = (float)videoPlayer.time;
         //   }

            // Keyboard shortcuts
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TogglePlayPause();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Rewind();
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                FastForward();
            }
     
    }

    // Method to play/pause the video
    public void TogglePlayPause()
    {
        if (isPaused)
        {
            if (videoPlayer.isPaused)
            {
                videoPlayer.Play();
            }
            if (endGameVideoPlayer.isPaused)
            {
                endGameVideoPlayer.Play();
            }
            if (howToPlayVideoPlayer.isPaused)
            {
                howToPlayVideoPlayer.Play();
            }
            pauseButton.SetActive(true);
            playButton.SetActive(false);
        }
        else
        {

            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            if (endGameVideoPlayer.isPlaying)
            {
                endGameVideoPlayer.Pause();
            }
            if (howToPlayVideoPlayer.isPlaying)
            {
                howToPlayVideoPlayer.Pause();
            }
            pauseButton.SetActive(false);
            playButton.SetActive(true);
        }
        isPaused = !isPaused;
    }

    // Method to rewind the video
    public void Rewind()
    {
        if (videoPlayer.time > 0 || howToPlayVideoPlayer.time > 0 || endGameVideoPlayer.time > 0)
        {
            videoPlayer.time -= rewindSpeed * Time.deltaTime;
            howToPlayVideoPlayer.time -= rewindSpeed * Time.deltaTime;
            endGameVideoPlayer.time -= rewindSpeed * Time.deltaTime;
        }
    }

    // Method to fast forward the video
    public void FastForward()
    {
        
        if (videoPlayer.time < videoPlayer.length || howToPlayVideoPlayer.time < howToPlayVideoPlayer.length || endGameVideoPlayer.time < endGameVideoPlayer.length)
        {
            videoPlayer.time += forwardSpeed * Time.deltaTime;
            howToPlayVideoPlayer.time += forwardSpeed * Time.deltaTime;
            endGameVideoPlayer.time += forwardSpeed * Time.deltaTime;
        }
    }

    // Method to skip the video and start the game
    public void SkipVideo()
    {
        videoPlayer.Stop();
        howToPlayVideoPlayer.Stop();
        endGameVideoPlayer.Stop();
        if (clock.runEndgameOnce == true) //bool FOR checking if the game has actually ended
        {
            gameManager.closeFinalVidbool = true;
        }
        videoPlayer.time = 0;
        howToPlayVideoPlayer.time = 0;
        endGameVideoPlayer.time = 0;
        videoPanel.SetActive(false); // Hide the video UI
        StartGame(); // Call method to start the game
    }
    
    // Handle progress bar scrubbing
    //public void ScrubVideo(float scrubTime)
    //{
    //    videoPlayer.time = scrubTime;
    //}
    

    // Called when the video finishes
    void EndReached(VideoPlayer vp)
    {
        
        videoPanel.SetActive(false); // Hide the video UI
        if (clock.runEndgameOnce == true) //bool FOR checking if the game has actually ended)
        {
            gameManager.closeFinalVidbool = true;
        }
        StartGame(); // Call method to start the game
    }

    

    // Show UI elements (fade in)
    void ShowUI()
    {
        StopAllCoroutines();
        StartCoroutine(FadeCanvasGroup(uiCanvasGroup, uiCanvasGroup.alpha, 1f, fadeDuration));
        isUIVisible = true;
    }

    // Hide UI elements (fade out)
    void HideUI()
    {
        StopAllCoroutines();
        StartCoroutine(FadeCanvasGroup(uiCanvasGroup, uiCanvasGroup.alpha, 0f, fadeDuration));
        isUIVisible = false;
    }

    // Coroutine to handle fading
    IEnumerator FadeCanvasGroup(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration)
    {
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        canvasGroup.alpha = endAlpha;
    }

    // Example method to start the game (replace with your actual game start code)
    void StartGame()
    {
        
        // Add your level loading or game start logic here.

        screensAppear.blankScreen.SetActive(false);

        screensAppear.videoImage.SetActive(false);
        screensAppear.backgroundMusic.volume = 1;
        screensAppear.backgroundMusic.Play();
    }
    
}
