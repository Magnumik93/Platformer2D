

public class CharecterDead : HealthBar
{
    public static void Dead()
    {
        panel.gameObject.SetActive(true);
        character.gameObject.SetActive(false);
    }
}
