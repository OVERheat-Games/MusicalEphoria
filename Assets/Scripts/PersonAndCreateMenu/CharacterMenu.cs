using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenu : MonoBehaviour
{ 
    public static CharacterMenu Instance {get; private set; }

    [SerializeField] private GameObject _characterMenu;
    [SerializeField] private GameObject _selectionMenu;

    private GameObject _hud;
    

    public void Awake() 
    {
        Instance = this;

        _hud = GameObject.Find("Hud");  
       
    }
    public void openCharacterMenu()
    {   
        _characterMenu.SetActive(true);

        Clock.startTime = false;
        _hud.SetActive(false);

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _characterMenu.transform.position = mousePosition;
    }

    public void closedCharacterMenu()
    {
        _hud.SetActive(true);
        Clock.startTime = true;

        _selectionMenu.SetActive(false);
        _characterMenu.SetActive(false);
    }
}
