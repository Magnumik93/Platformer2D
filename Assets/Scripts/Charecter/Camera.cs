using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Camera : MonoBehaviour
{
    private GameObject _charecter;
    private GameObject _gameOverPanel;
    private GameObject _pause;
    
    private float _zoom = -10f;

    private void Awake()
    {
        _charecter = GameObject.FindWithTag("Player");
        _gameOverPanel = GameObject.Find("GameOverPanel");
        _pause = GameObject.Find("PauseMenu");
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    private void Start()
    {
        if (_gameOverPanel.activeInHierarchy == true)
        {
            _gameOverPanel.SetActive(false);
        }

        if (_pause.activeInHierarchy == true)
        {
            _pause.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        transform.position = _charecter.transform.position;
        var vector3 = transform.position;
        vector3.z = _zoom;
        transform.position = vector3;
    }

    public void OnClick()
    {
        if (Time.timeScale == 1)
            Time.timeScale = 0;
        
        _pause.SetActive(true);
    }
}
