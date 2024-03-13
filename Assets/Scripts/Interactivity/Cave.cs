using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Cave : MonoBehaviour
{
    [SerializeField] private GameObject alarm;
   
    private int count;
    
    private void Awake()
    {
        count = 0;
        alarm.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<CharecterMove>() != null && count == 0)
        {
            alarm.SetActive(true);
            count += 1;
        }
    }
}
