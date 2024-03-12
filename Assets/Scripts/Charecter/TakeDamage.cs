using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    private SpriteRenderer _sr;
    private float _move;
    private Rigidbody2D _rb;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
    }
    
    private void Update()
    {
        if (_sr.flipX == true) _move = 1;
        else _move = -1;
    }

    private void OnCollisionEnter2D(Collision2D game)
    {
        if (game.gameObject.tag == "Dead")
        {
            HealthBar.Health();
            _sr.color = Color.red; 
            Invoke("Collor",0.3f);
            PushAway(transform.position, 200f);
        }
    }

    private void Collor()
    {
        _sr.color = Color.white;
    }

    public void PushAway(Vector3 pushFrom, float pushPower)
    {
        if(_rb == null||pushPower == 0) return;
        pushFrom.x -= _move;
        var pushDirection = (pushFrom - transform.position).normalized;
        _rb.AddForce((-pushDirection * pushPower));
    }
}
