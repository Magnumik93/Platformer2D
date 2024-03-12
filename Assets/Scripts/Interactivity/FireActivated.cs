using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireActivated : MonoBehaviour
{
    [SerializeField] private GameObject _finish;
    [SerializeField] private GameObject _tilemap;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _tilemap.SetActive(true);
            _finish.SetActive(true);
        }
    }
}
