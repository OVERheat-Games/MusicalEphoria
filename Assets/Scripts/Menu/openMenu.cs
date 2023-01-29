using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openMenu : MonoBehaviour
{
    public static openMenu Instance {get; private set; }

    private GameObject _creationMenu;

    private void Awake() 
    {
        Instance = this;
        _creationMenu = GameObject.Find("Create Song Menu");
    }

   public void createMenu()
    {  
        _creationMenu.SetActive(true);

    }
}
