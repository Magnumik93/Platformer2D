using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private SpriteRenderer _charecterSR;
    private GameObject _charecter;
    private CharecterMove _charecterMove;
     
    [SerializeField] private float delay = 0.5f;
    [SerializeField] private float color = 0.1f;

    private uint lastSceneIndex = 2;

    private void Awake()
    {
        _charecter = GameObject.Find("Charecter");
        _charecterSR = _charecter.GetComponent<SpriteRenderer>();
        _charecterMove = _charecter.GetComponent<CharecterMove>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<CharecterMove>() != null)
        {
            OnFinish();
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<CharecterMove>() != null)
        {
            if(_charecterMove.enabled == true)
                _charecterMove.enabled = false;
        }
    }
    

    private void OnTriggerExit2D(Collider2D other)
    {
        var sceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(sceneIndex);
        if (sceneIndex < lastSceneIndex)
        {
            SceneManager.LoadScene(sceneIndex + 1);
        }else SceneManager.LoadScene(0);
    }

    void OnFinish()
    {
        if(_charecterSR.color.a < 0.3)
            _charecter.SetActive(false);

        if(_charecterSR.color.a > 0 && _charecter.activeInHierarchy)   
            Invoke("AlphaCharecter", delay);
    }

    void AlphaCharecter()
    {
        Color charecterSrColor = _charecterSR.color;
        charecterSrColor.a -= color;
        _charecterSR.color = charecterSrColor;
        OnFinish();
    }
}
