using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HiddenInteractivity : MonoBehaviour
{
    [SerializeField] private GameObject tile;
    [SerializeField] private GameObject finish;
    [SerializeField] private GameObject fire;
    [SerializeField] private Tilemap caveTilemap;
    [SerializeField] private TilemapRenderer caveTR;

    private void Awake()
    {
        tile.SetActive(false);
        finish.SetActive(false);
        fire.SetActive(false);
        caveTR.sortingOrder = 1;
        var color = caveTilemap.color;
        color.a = 1;
        caveTilemap.color = color;
    }
}
