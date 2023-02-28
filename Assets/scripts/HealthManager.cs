using UnityEngine;
using UnityEngine.UI;  //At the top of the script
public class HealthManager : MonoBehaviour
{
    public Behaviour[] disabledOnDeath;
    public float health = 100f;

    public Image healthbar;
    public GameObject MenuPanel;
    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
            if (MenuPanel != null)
            {
                MenuPanel.SetActive(true);
            }
        }
        if (healthbar != null)
        {
            healthbar.fillAmount = health / 100;
        }
    }
    public void Die()
    {
        //Disable all the components inside the disableOnDeath array that you will assign from the inspector
        foreach (Behaviour behaviour in disabledOnDeath)
        {
            behaviour.enabled = false;
        }
    }
}
