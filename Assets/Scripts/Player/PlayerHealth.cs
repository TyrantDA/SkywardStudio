using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public HealthBar healthbar;
    [SerializeField] int maxHealth;
    [SerializeField] int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        healthbar.SetMaxHealth(maxHealth);
        currentHealth = maxHealth;
    }

    public void dealDamage(int damge)
    {
        currentHealth -= damge;
    }

    void playerDeath()
    {
        SceneManager.LoadScene("Overworld_Map");
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            playerDeath();
        }

    }
}
