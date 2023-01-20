using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_menu : MonoBehaviour
{
  public GameObject Menu;
  public Animation CameraFOV; 
  bool MenuON = false;

 private void Update() 
 {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit _hit;
    if(Physics.Raycast(ray, out _hit, Mathf.Infinity))
    {
      if(Input.GetMouseButtonDown(0))
      { 
        if(MenuON == false)
        {
          Menu.SetActive(true);
          MenuON = true;
          CameraFOV = GetComponent<Animation>();
          CameraFOV.Play("CameraFoV+"); 
        }
        else
        {
          Menu.SetActive(false);
          MenuON = false;
          CameraFOV = GetComponent<Animation>();
          CameraFOV.Play("CameraFoV-");
        }
                    
      } 
    }
  } 
  
}
