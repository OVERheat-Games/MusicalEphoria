using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private GameObject _characterMenu;
    [SerializeField] private GameObject _selectionMenu;
    [SerializeField] private GameObject _hud;

    private bool characterMenuOpen;
    private bool selectionMenuOpen;
    private bool gameMenu = false;

    public Animation CameraFOV;

    RaycastHit _hit;

    public void openSelectionMenu()
    {  
        Clock.startTime = false;
        _selectionMenu.SetActive(true);
        _hud.SetActive(false);

        CameraFOV = GetComponent<Animation>();
        CameraFOV.Play("CameraFoV+");

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _selectionMenu.transform.position = mousePosition;
    }    

    public void closedSelectionMenu()
    {   
        Clock.startTime = true;
        selectionMenuOpen = false;
        _selectionMenu.SetActive(false);
        _hud.SetActive(true);

        CameraFOV = GetComponent<Animation>();
        CameraFOV.Play("CameraFoV-");
    }   

    public void openCharacterMenu()
    {
        Clock.startTime = false;
        characterMenuOpen = true;
        _characterMenu.SetActive(true);
        _hud.SetActive(false);

        CameraFOV = GetComponent<Animation>();
        CameraFOV.Play("CameraFoV+");

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _selectionMenu.transform.position = mousePosition;
    }

    public void closedCharacterMenu()
    {
        Clock.startTime = true;
        characterMenuOpen = false;
        _characterMenu.SetActive(false);
        _hud.SetActive(true);

        CameraFOV = GetComponent<Animation>();
        CameraFOV.Play("CameraFoV-");

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _selectionMenu.transform.position = mousePosition;
    }

    private void Update() 
    {   
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit _hit;

        if(Physics.Raycast(ray, out _hit, Mathf.Infinity))
        {
            if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "OpenSelectionMenu")
            {
                gameMenu = true;
                if(gameMenu)
                {
                    openSelectionMenu();
                }
                else
                {
                    closedSelectionMenu();
                } 
            }  

            if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "OpenCharacterMenu")
            {
                if(gameMenu == false)
                {
                    openCharacterMenu();
                }
                else
                {
                    closedCharacterMenu();
                } 
            }  
        }      
    }    
}
