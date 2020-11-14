using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour, ITakeDamage, IGameObjectPooled
{
    public HealthBar healthBar;
    [SerializeField]
    float maxhealth = 100f;
    private GameObjectPool pool;

    [SerializeField]
    GameEvent enemyDeath = default(GameEvent);


    float health;
    void Start()
    {
        health = maxhealth;
        healthBar.SetMaxHealth(health);
    }

  
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
        if (health <= 0)
        {
            pool.ReturnToPool(this.gameObject);
            enemyDeath.Raise();
            health = maxhealth;
            healthBar.SetMaxHealth(health);
            
        }
           
    }

    public GameObjectPool Pool
    {
        get
        {
            return pool;
        }

        set
        {
            if (pool == null)
            {
                pool = value;
            }
        }
    }
 }
