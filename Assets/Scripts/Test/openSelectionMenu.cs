using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSelectionMenu : MonoBehaviour
{
    public static openSelectionMenu Instance {get; private set; }

    private GameObject _selectionMenu;

    void Awake()
    {
        Instance = this;
        _selectionMenu = GameObject.Find("Selection_Menu"); 
    }
    
    public void selectionMenuOpen()
    {
        
        {
            _selectionMenu.SetActive(true);

            
        }
        
    }

}
