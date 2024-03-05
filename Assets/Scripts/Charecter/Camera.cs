using UnityEngine;
using UnityEngine.Serialization;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject charecter;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pouse;
    
    [SerializeField] private float zoom = -10f;
    
    void Start()
    {
        gameOverPanel.SetActive(false);
        charecter.SetActive(true);
        pouse.SetActive(false);
    }

    void FixedUpdate()
    {
        transform.position = charecter.transform.position;
        var vector3 = transform.position;
        vector3.z = zoom;
        transform.position = vector3;
    }

    public void OnClic()
    {
        if (Time.timeScale == 1)
            Time.timeScale = 0;
        
        pouse.SetActive(true);
    }
}
