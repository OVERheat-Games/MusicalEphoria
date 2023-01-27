using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_menu : MonoBehaviour
{
  
  public GameObject HUD;
  public GameObject Menu;
  public GameObject[] changeMenu;

  public Animation CameraFOV;

  public static bool MenuON = false;
  bool createSongMenu = false;

  private void Awake() 
  {
    
  }
  void Update() 
 {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit _hit;
    if(Physics.Raycast(ray, out _hit, Mathf.Infinity))
    {
      if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "Open_Menu" && createSongMenu == false)
      { 
        
        if(MenuON == false)
        {
          Clock.startTime = false;
          HUD.SetActive(false);
          changeMenu[0].SetActive(true);
          MenuON = true;

          CameraFOV = GetComponent<Animation>();
          CameraFOV.Play("CameraFoV+");

          Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          changeMenu[0].transform.position = mousePosition;
        }
        else
        {
          changeMenu[1].SetActive(false);
          Clock.startTime = true;
          HUD.SetActive(true);
          changeMenu[0].SetActive(false);
          MenuON = false;

          CameraFOV = GetComponent<Animation>();
          CameraFOV.Play("CameraFoV-");
        }            
      } 
          if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "OpenCreateMenu")
          {
            createSongMenu = true;
            changeMenu[0].SetActive(false);
            MenuON = true;
            Menu.SetActive(true);
          }
          if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "exitMenu")
          {
            Clock.startTime = true;
            MenuON = false;
            Menu.SetActive(false);
            HUD.SetActive(true);
            createSongMenu = false;
            CameraFOV = GetComponent<Animation>();
            CameraFOV.Play("CameraFoV-");
          }
          if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "Personal_Menu" && createSongMenu == false)
      { 
        if(MenuON == false)
        {
          Clock.startTime = false;
          HUD.SetActive(false);
          changeMenu[1].SetActive(true);
          MenuON = true;

          CameraFOV = GetComponent<Animation>();
          CameraFOV.Play("CameraFoV+");
        }
        else 
        {
          Clock.startTime = true;
          HUD.SetActive(true);
          changeMenu[1].SetActive(false);
          MenuON = false;
          changeMenu[0].SetActive(false);

          CameraFOV = GetComponent<Animation>();
          CameraFOV.Play("CameraFoV-");
        }
      }
    }
  } 
  
}