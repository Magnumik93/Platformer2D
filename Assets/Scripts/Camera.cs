using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject obj;

    public GameObject charecter;
    public GameObject gameOverPanel;
    public GameObject panel;
    private GameObject clone;
    public float zoom = -10f;
    
    void Start()
    {
        gameOverPanel.SetActive(false);
        charecter.SetActive(true);
        clone = Canvas.Instantiate(panel);
        clone.SetActive(false);
    }

    void FixedUpdate()
    {
        obj.transform.position = charecter.transform.position;
        var vector3 = obj.transform.position;
        vector3.z = zoom;
        obj.transform.position = vector3;
    }

    public void OnClic()
    {
        clone.SetActive(true);
    }
}
