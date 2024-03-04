using System;
using Unity.VisualScripting;
using UnityEngine;

public class HealthDead : MonoBehaviour
{
    public GameObject healthBar;
    private int score = 5;
    private SpriteRenderer sr;
    private float move;
    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (sr.flipX == true) move = 1;
        else move = -1;

    }

    private void OnCollisionEnter2D(Collision2D game)
    {
        if (game.gameObject.tag == "Dead")
        {
            HealthBar.Health();
            sr.color = Color.red; 
            Invoke("Collor",0.3f);
            PushAway(transform.position, 200f);

        }

        
    }

    private void Collor()
    {
        sr.color = Color.white;
    }

    public void PushAway(Vector3 pushFrom, float pushPower)
    {
        if(rb == null||pushPower == 0) return;
        pushFrom.x -= move;
        var pushDirection = (pushFrom - transform.position).normalized;
        rb.AddForce((-pushDirection * pushPower));
    }
}
