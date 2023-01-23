using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_menu : MonoBehaviour
{
  public GameObject Step_One;
  public GameObject Menu;


  public Animation CameraFOV; 


  public static bool MenuON = false;
  bool Step1 = false;


 private void Update() 
 {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit _hit;
    if(Physics.Raycast(ray, out _hit, Mathf.Infinity))
    {
      if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "Open_Menu" && Step1 == false)
      { 
        
        if(MenuON == false)
        {
          Menu.SetActive(true);
          MenuON = true;
          CameraFOV = GetComponent<Animation>();
          CameraFOV.Play("CameraFoV+"); 
          Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          Menu.transform.position = mousePosition;
        }
        else
        {
          Menu.SetActive(false);
          MenuON = false;
          CameraFOV = GetComponent<Animation>();
          CameraFOV.Play("CameraFoV-");
        }            
      } 
          if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "Open_Step")
          {
            Step1 = true;
            Menu.SetActive(false);
            MenuON = true;
            Step_One.SetActive(true);
          }
    }
  } 
  
}
