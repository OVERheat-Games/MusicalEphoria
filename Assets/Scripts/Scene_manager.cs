using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_manager : MonoBehaviour
{
    public void StartGame(int _SceneNumber)
    {
        SceneManager.LoadScene(_SceneNumber);
    }
    
}
