using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ActivePlayerHealth : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager manager;
    [SerializeField] public float maxHealth;

    public float currentHealth;
    public Image healthBar;

    void Start()
    {
        currentHealth = maxHealth;    
    }
    public void TakeDamage (float damage)
    {
        currentHealth -= damage;
        healthBar.fillAmount = currentHealth / maxHealth;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            
           SceneManager.LoadScene(0);
            Debug.Log("You Win");
        }
    }
    public void HealDamage (float healPoints)
    {
        currentHealth += healPoints;
        healthBar.fillAmount = currentHealth / maxHealth;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }
}

