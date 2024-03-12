using System;
using UnityEngine;

public class CharecterMove : MonoBehaviour 
{
    //[SerializeField] protected PrefabOverride spawnBox;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForse;
    [SerializeField] private int jumpCount = 2;

    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    
    private float _movement;
    private int _count = 2;
    private bool _isJump = false;
    
    private Animator _anim;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
        _sr.flipX = false;
    }

    private void Update()
    {
        
        _movement = Input.GetAxis("Horizontal");
        
        if (Input.GetKeyDown(KeyCode.Space) && _count > 1 )
        {
            _isJump = true;
            _count--;
        }

        if (_movement < 0 || _movement > 0)
        {
            Flip();
        }

        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            _anim.StopPlayback();
        }
        else
        {
            _anim.StartPlayback();
        }

        /*if (Input.GetKeyDown(KeyCode.E))
        {
            HideBox();
            CreateBox();
        }*/
    }

    private void FixedUpdate()
    { 
        transform.position += new Vector3(_movement, 0, 0) * (speed * Time.fixedDeltaTime);
        
        if (Math.Abs(_rb.velocity.y) < 0.02f) _count = jumpCount;
        if (_isJump)
        {
            _rb.AddForce(new Vector2(0, jumpForse), ForceMode2D.Impulse);
            _isJump = false;
        }
    }

    private void Flip()
    {
        _sr.flipX = _movement < 0 ? true : false;
    }
}
