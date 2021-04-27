using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainMenuButtonsController : MonoBehaviour
{
    public GameObject missions;
    public GameObject mainMenu;
    public GameObject fightingMenu;
    public GameObject Back;
    private GameObject currentMenu;
    public GameObject profile;

    private void Start()
    {
        currentMenu = mainMenu;
    }

    /*private void FixedUpdate()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.deltaPosition.x > 3f)
            {
                Debug.Log("right");
            }
            if (touch.deltaPosition.x < 3f)
            {
                Debug.Log("left");
                profile.SetActive(!profile.activeSelf);
            }
        }
    }*/
    public void OpenMissions()
    {
        currentMenu = missions;

        missions.SetActive(!missions.activeSelf);

        mainMenu.SetActive(!mainMenu.activeSelf);

    }

    public void OpenFightingMenu()
    {
        currentMenu = fightingMenu;
        fightingMenu.SetActive(!fightingMenu.activeSelf);

        mainMenu.SetActive(!mainMenu.activeSelf);
    }

    public void BackTo()
    {
        

        currentMenu.SetActive(!currentMenu.activeSelf);

        mainMenu.SetActive(!mainMenu.activeSelf);

        currentMenu = mainMenu;
    }
}
