using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionMenu : MonoBehaviour
{
    public static SelectionMenu Instance {get; private set; }

    [SerializeField] private GameObject _selectionMenu;
    [SerializeField] private GameObject _characterMenu;

    private GameObject _hud;

    private void Awake() 
    {

        Instance = this;
        
       _hud = GameObject.Find("Hud");  
    }

    public void openSelectionMenu()
    {  
        _selectionMenu.SetActive(true);

        _hud.SetActive(false);
        Clock.startTime = false;

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _selectionMenu.transform.position = mousePosition;
    } 

    public void closedSelectionMenu()
    {   
        _hud.SetActive(true);
        Clock.startTime = true;

        _characterMenu.SetActive(false);
        _selectionMenu.SetActive(false);
        
    } 
}
