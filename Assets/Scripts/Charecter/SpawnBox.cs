using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnBox :MonoBehaviour, IBox
{
    [SerializeField] private GameObject _box;
    [SerializeField] private GameObject _charecter;

    private void Awake()
    {
        _box.SetActive(false); 
    }

    public void CreateBox()
    {
        if(_box.activeInHierarchy == false)
            _box.SetActive(true);
        Invoke("HideBox", 5f);
    }
    

    public Vector3 MouseCursor { get; set; }

    public void HideBox()
    {
        if(_box.activeInHierarchy == true)
            _box.SetActive(false);
    }
}
