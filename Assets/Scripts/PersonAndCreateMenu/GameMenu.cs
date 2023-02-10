using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private GameObject _characterMenu;
    

    private bool characterMenuOpen;
    public static bool selectionMenuOpen;
    private  bool gameMenu = false;

    public Animation CameraFOV;

    RaycastHit _hit;

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
                    CameraFOV.Play("CameraFoV+");
                    gameMenu = true;
                    SelectionMenu.Instance.openSelectionMenu();
                }
                else
                {
                    CameraFOV.Play("CameraFoV-");
                    gameMenu = false;
                    SelectionMenu.Instance.closedSelectionMenu();
                } 
            }
            
            if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "OpenCharacterMenu" && characterMenuOpen == false)
            {
                if(gameMenu == false)
                {
                    CameraFOV.Play("CameraFoV+");
                    gameMenu = true;
                    CharacterMenu.Instance.openCharacterMenu();
                }
                else
                {
                    CameraFOV.Play("CameraFoV-");
                    gameMenu = false;
                    CharacterMenu.Instance.closedCharacterMenu();
                } 
            }      
        }      
    }    
}
