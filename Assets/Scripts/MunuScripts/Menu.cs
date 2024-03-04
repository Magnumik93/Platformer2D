using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject option;
    public GameObject info;

    private void Start()
    {
        menu.SetActive(true);
        option.SetActive(false);
        info.SetActive(false);
    }

    public void StartOnClic()
    {
        SceneManager.LoadScene("LVL1");
    }
    public void OptionOnClic()
    {
        menu.SetActive(false);
        option.SetActive(true);
    }
    public void InfoOnClic()
    {
        menu.SetActive(false);
        info.SetActive(true);
    }
    public void ExitOnClic()
    {
        
    }
    
}
