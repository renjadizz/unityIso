using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEngine.SceneManagement;
using System;

public class PlayerScript : MonoBehaviour, ITakeDamage
{
    [SerializeField]
    public PlayerMovement movementScript;
    [SerializeField]
    public PlayerShooting shootingScript;
    [SerializeField]
    public MouseClickSender mouseClickSender;
    [NonSerialized]
    public MovementAnimationController animationController;
    public HealthBar healthBar;

    public CapsuleCollider2D playerCollider;
    public Rigidbody2D rb;

    public FloatVariable Health;

    
    void Awake()
    {
        animationController = GetComponentInChildren<MovementAnimationController>();
        playerCollider = GetComponent<CapsuleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        healthBar.SetMaxHealth(Health.value);
    }
    
    public void TakeDamage(float damage)
    {
        Health.value -= damage;
        healthBar.SetHealth(Health.value);
        if (Health.value <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(gameObject);
            Health.value = 100f;
        }
    }
}
