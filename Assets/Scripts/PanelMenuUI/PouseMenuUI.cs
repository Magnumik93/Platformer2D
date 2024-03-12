using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PouseMenuUI : MonoBehaviour
{
    public void OnMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void OnExit()
    {
        if (Time.timeScale == 0)
            Time.timeScale = 1;
        
        gameObject.SetActive(false);
    }
}
