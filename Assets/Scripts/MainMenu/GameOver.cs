using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject charecter;
    public GameObject button;
    public string nameScene;
    
    private void Update()
    {
        charecter.SetActive(false);
    }
    
    public void onClic()
    {
        Invoke("LoadScene", 0.2f); 
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
