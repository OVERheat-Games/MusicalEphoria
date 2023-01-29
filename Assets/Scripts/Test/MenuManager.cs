using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit _hit;
        if(Physics.Raycast(ray, out _hit, Mathf.Infinity))
        {
            if(Input.GetMouseButtonDown(0))
              openSelectionMenu.Instance.selectionMenuOpen();  
        }
    }
}
