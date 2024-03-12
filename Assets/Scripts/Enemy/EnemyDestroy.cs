using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField] private GameObject pref;
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionStay2D(Collision2D charecter)
    {
        if (charecter.gameObject.CompareTag("Player"))
        {
            GameObject.Destroy(pref);
        }
    }
}
