using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_menu : MonoBehaviour
{
 public GameObject Menus;
 public Animation CameraFOV; 
 bool MenuON = false;
 public GameObject prefab;

 private void Update() 
 {
   if (Input.GetKey(KeyCode.Mouse0) && MenuON == false) 
   {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit _hit;
      if (Physics.Raycast(ray))
      {
        Menus.SetActive(true);
        MenuON = true;
        if(Menus == true)
        {
          CameraFOV = GetComponent<Animation>();
          CameraFOV.Play("CameraFoV");
        }
        if(Physics.Raycast(ray, out _hit, Mathf.Infinity))
        {

        }
      }
   } 
  }
}
