using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public static GameObject character;

    //private float health = 100f;
    private static Scrollbar sb;
    private ColorBlock block;
    public static GameObject panel;
    
    
    void Start()
    {
        character = GameObject.FindWithTag("Player");
        panel = GameObject.Find("GameOverPanel");
        sb = GetComponent<Scrollbar>(); 
        block = sb.colors;
        block.normalColor = Color.green;
        sb.colors = block;
        sb.value = 0;
        sb.size = 1;
    }

    private void FixedUpdate()
    {
        if (sb.size > 0.61 && sb.size <= 1)
        {
            block = sb.colors;
            block.normalColor = Color.green;
            sb.colors = block;
        }
        else if (sb.size>0.26 && sb.size < 0.6)
        {
            block = sb.colors;
            block.normalColor = Color.yellow;
            sb.colors = block;
        }else if (sb.size>0.001 && sb.size < 0.25)
        {
            block = sb.colors;
            block.normalColor = Color.red;
            sb.colors = block;
        }else if (sb.size <= 0)
        {
            block = sb.colors;
            var colors = block.normalColor;
            colors.a = 0;
            block.normalColor = colors;
            sb.colors = block;
        }

        if (sb.size == 0 || character.transform.position.y < -19f)
        {
            CharecterDead.Dead();
        }
    }

    public static void Health()
    {
        sb.size -= 0.05f;
    }
}
