using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preparing_Menu : MonoBehaviour
{
    public GameObject[] customizationSong;

    private Spawn_menu Menu;

    private void Awake() 
    {
        Menu = GetComponent<Spawn_menu>(); 
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit _hit;
        if(Physics.Raycast(ray, out _hit, Mathf.Infinity))
        {
            if(Input.GetMouseButtonDown(0) && _hit.transform.tag == "Genre")
            {
                customizationSong[0].SetActive(true);

            }
        }
    }
}