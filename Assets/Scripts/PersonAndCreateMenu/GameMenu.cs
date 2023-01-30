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
        gameMenu = true;
        _selectionMenu.SetActive(true);

        _hud.SetActive(false);
        Clock.startTime = false;

        CameraFOV = GetComponent<Animation>();
        CameraFOV.Play("CameraFoV+");

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _selectionMenu.transform.position = mousePosition;
    }    

    public void closedSelectionMenu()
    {   
        _hud.SetActive(true);
        Clock.startTime = true;

        _characterMenu.SetActive(false);
        gameMenu = false;
        _selectionMenu.SetActive(false);
        
        CameraFOV = GetComponent<Animation>();
        CameraFOV.Play("CameraFoV-");
    }   

    public void openCharacterMenu()
    {   
        _characterMenu.SetActive(true);
        gameMenu = true;

        Clock.startTime = false;
        _hud.SetActive(false);

        CameraFOV = GetComponent<Animation>();
        CameraFOV.Play("CameraFoV+");

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _selectionMenu.transform.position = mousePosition;
    }

    public void closedCharacterMenu()
    {
        _hud.SetActive(true);
        Clock.startTime = true;

        _selectionMenu.SetActive(false);
        _characterMenu.SetActive(false);
        gameMenu = false;

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
            if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "OpenSelectionMenu" && selectionMenuOpen == false)
            {
                if(gameMenu == false)
                {
                    openSelectionMenu();
                }
                else
                {
                    closedSelectionMenu();
                } 
            }
            if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "OpenCharacterMenu" && characterMenuOpen == false)
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
