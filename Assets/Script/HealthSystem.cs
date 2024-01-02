using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Text HethText;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateScore()
    {
        HethText.text = "Heath : " + currentHealth.ToString();
    }



    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            // Perform actions for when the player dies
            Die();
        }
        UpdateScore();

        print("Damage Amount " + currentHealth);
    }

    void Die()
    {
        // Handle player death, e.g., respawn logic
        Debug.Log("Player died!");
        // Implement your respawn logic or game over actions here
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;

        }
            

      
    }
}
