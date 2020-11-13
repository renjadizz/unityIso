using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour, ITakeDamage
{
    public HealthBar healthBar;
    [SerializeField]
    float maxhealth = 100f;


    float health;
    void Start()
    {
        health = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
    }

  
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
        if (health <= 0)
            Destroy(gameObject);
    }
}
