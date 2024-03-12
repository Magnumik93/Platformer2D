using UnityEngine;


public class StartSpawn : MonoBehaviour
{
    private float _delay = 1f;
    private float _aColor = 0.3f;
    
    private SpriteRenderer _сharecterSr; 
    private SpriteRenderer _spriteRenderer;
    private CharecterMove _move;
    private GameObject _charecter;


    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _charecter = GameObject.FindWithTag("Player");
        _сharecterSr = _charecter.GetComponent<SpriteRenderer>();
        _move = _charecter.GetComponent<CharecterMove>();
    }

    private void Start()
    {
        gameObject.SetActive(true);
        Color spriteRendererColor = _spriteRenderer.color;
        spriteRendererColor.a = 0;
        _spriteRenderer.color = spriteRendererColor;
        
        _charecter.SetActive(true);
        Color srColor = _сharecterSr.color;
        srColor.a = 0;
        _сharecterSr.color = srColor;
        _move.enabled = false;
        _charecter.transform.position = transform.position;
    }

    void Update()
    {
        if (_spriteRenderer.color.a == 0)
        {
            Portal();
        }

        if (_сharecterSr.color.a > 0.95)
        {
            _move.enabled = true;
            Portal();
        }
    }

    void Portal()
    {
        if (_spriteRenderer.color.a == 0)
        {
            PortalActive();
            Invoke("CharacterActive", _delay);
        }
        
        if (_spriteRenderer.color.a < 1 )
        Invoke("PortalActive", _delay);
        
        if(_move.enabled == true)
            Invoke("ClosePortal", 4f);
            
    }

    void Character()
    {
        if (_сharecterSr.color.a == 0)
            CharacterActive();
        
        if (_сharecterSr.color.a < 1)
        Invoke("CharacterActive", _delay);
    }

    void PortalActive()
    {
        Color spriteRendererColor = _spriteRenderer.color;
        spriteRendererColor.a += _aColor;
        _spriteRenderer.color = spriteRendererColor;
        Portal();
    }

    void ClosePortal()
    {
        gameObject.SetActive(false);
    }

    void CharacterActive()
    {
        Color srColor = _сharecterSr.color;
        srColor.a += _aColor;
        _сharecterSr.color = srColor;
        Character();
    }
}
