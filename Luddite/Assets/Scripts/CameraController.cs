using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject zoomInButton;
    public GameObject zoomOutButton;
    public GameObject moveCameraUpButton;
    public GameObject moveCameraDownButton;

    private int cameraPos;

    public void ZoomInButtonIsClicked()
    {
        gameObject.transform.position = new Vector3(0, 5, 0);
        zoomInButton.SetActive(false);
        zoomOutButton.SetActive(true);
        moveCameraUpButton.SetActive(true);
        moveCameraDownButton.SetActive(true);
        cameraPos = 2;
    }

    public void ZoomOutButtonIsClicked()
    {
        gameObject.transform.position = new Vector3(0, 13, 0);
        zoomInButton.SetActive(true);
        zoomOutButton.SetActive(false);
        moveCameraUpButton.SetActive(false);
        moveCameraDownButton.SetActive(false);
    }

    public void moveCameraUpButtonIsClicked()
    {
        cameraPos -= 1;
        if (cameraPos == 1)
        {
            gameObject.transform.position = new Vector3(0, 5, -4);
            moveCameraUpButton.SetActive(false);
        }
        else if (cameraPos == 2)
        {
            gameObject.transform.position = new Vector3(0, 5, 0);
            moveCameraDownButton.SetActive(true);
        }
    }

    public void moveCameraDownButtonIsClicked()
    {
        cameraPos += 1;
        if (cameraPos == 2)
        {
            gameObject.transform.position = new Vector3(0, 5, 0);
            moveCameraUpButton.SetActive(true);
        }
        else if (cameraPos == 3)
        {
            gameObject.transform.position = new Vector3(0, 5, 4);
            moveCameraDownButton.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
