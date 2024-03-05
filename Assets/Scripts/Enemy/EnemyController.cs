using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 4f;
    private Rigidbody2D rb;
    private int move;
    private SpriteRenderer sr;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        move = 1;
        sr.flipX = true;
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(move, 0, 0) * speed * Time.deltaTime;
    }

    private void OnCollisionExit2D(Collision2D triger)
    {
        if (triger.gameObject.tag=="Trigger")
        {
                move *= -1;
            

            if (move < 0) sr.flipX = false;
            else
            {
                sr.flipX = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            move *= -1;
            if (sr.flipX == true) sr.flipX = false;
            else sr.flipX = true;
        }
    }
}

