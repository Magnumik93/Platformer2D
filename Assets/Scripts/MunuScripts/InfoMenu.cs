using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMenu : MonoBehaviour
{
    public GameObject info;
    public GameObject menu;

    public void BackOnClic()
    {
        menu.SetActive(true);
        info.SetActive(false);
    }
}
