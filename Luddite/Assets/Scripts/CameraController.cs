using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   
    public bool zoomOutisHeldDown = false;
    public bool zoomInisHeldDown = false;


    public float cameraMoveSpeed;


    public Vector3 cameraPosition;

  
    

    public void ZoomOutonPress()
    {
        zoomOutisHeldDown = true;    
    }

    public void ZoomOutonRelease()
    {
        zoomOutisHeldDown = false;
    }

    public void ZoomInonPress()
    {
        zoomInisHeldDown = true;
    }

    public void ZoomInonRelease()
    {
        zoomInisHeldDown = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && cameraPosition.z > -7)
        {
            cameraPosition.z -= cameraMoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) && cameraPosition.z < 7)
        {
            cameraPosition.z += cameraMoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && cameraPosition.x < 5)
        {
            cameraPosition.x += cameraMoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) && cameraPosition.x > -5)
        {
            cameraPosition.x -= cameraMoveSpeed * Time.deltaTime;
        }
        if (zoomOutisHeldDown == true && cameraPosition.y < 14)
        {
            cameraPosition.y += cameraMoveSpeed * Time.deltaTime;
        }

        if (zoomInisHeldDown == true && cameraPosition.y > 4)
        {
            cameraPosition.y -= cameraMoveSpeed * Time.deltaTime;
        }

        this.transform.position = cameraPosition;
    }

   
    
}
