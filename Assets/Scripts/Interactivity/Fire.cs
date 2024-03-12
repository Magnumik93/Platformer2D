using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject _fire;
    [SerializeField] private GameObject _alarm;
    [SerializeField] private Tilemap _caveTilemap;
    private TilemapRenderer _caveTr;

    private void Awake()
    {
        _caveTr = _caveTilemap.GetComponent<TilemapRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (_alarm.activeSelf)
            {
                _alarm.SetActive(false);
            }
            _fire.SetActive(true);
            var color = _caveTilemap.color;
            color.a = 0.6f;
            _caveTilemap.color = color;
            _caveTr.sortingOrder = -1;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _fire.SetActive(false);
            var color = _caveTilemap.color;
            color.a = 1;
            _caveTilemap.color = color;
            _caveTr.sortingOrder = 1;
        }
    }
}
