using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_controller : MonoBehaviour
{
    public Camera mapCamera;
    public Camera mainCamera;
    public bool mapOpen = false;
    public GameObject mapIcon;
    // Start is called before the first frame update
    void Start()
    {
        mapIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && (mapOpen == true))
        {
            CloseMap();
            mapOpen = false;
            mapIcon.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.M) && (mapOpen == false))
        {
            OpenMap();
            mapOpen = true;
            mapIcon.SetActive(true);
        }
    }

    public void OpenMap()
    {
        mainCamera.enabled = false;
        mapCamera.enabled = true;
    }

    public void CloseMap()
    {
        mainCamera.enabled = true;
        mapCamera.enabled = false;
    }
}
