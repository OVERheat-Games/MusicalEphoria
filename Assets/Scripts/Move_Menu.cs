using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Menu : MonoBehaviour
{
    void Update()
    { 
        if(Input.GetMouseButtonDown(0) && Spawn_menu.MenuON == false)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition;
        }
    }
}
