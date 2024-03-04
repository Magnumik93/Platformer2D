using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public GameObject pref;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    private void OnCollisionStay2D(Collision2D charecter)
    {
        if (charecter.gameObject.tag == "Player")
        {
            GameObject.Destroy(pref);
            Debug.Log("DEstr");
        }
    }

    
}
