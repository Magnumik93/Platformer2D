using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public GameObject option;
    public GameObject menu;

    public void BackOnClic()
    {
        menu.SetActive(true);
        option.SetActive(false);
    }
}
