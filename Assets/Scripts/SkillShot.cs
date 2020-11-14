using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillShot : MonoBehaviour, IGameObjectPooled
{
    [SerializeField]
    float moveSpeed = 20f;
    [SerializeField]
    float liveTimer = 0.5f;
    [SerializeField]
    float attackPower = 10f;

    float fireTimer = 0f;


    private GameObjectPool pool;
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
   
    public void Setup(Vector3 shootDir)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(shootDir * moveSpeed, ForceMode2D.Impulse);
       
    }
    public void FixedUpdate()
    {
        fireTimer += Time.deltaTime;
        if (fireTimer >= liveTimer)
        {
            fireTimer = 0;
            pool.ReturnToPool(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ITakeDamage damagable = collision.GetComponent<ITakeDamage>();
        if (damagable != null)
        {
            damagable.TakeDamage(attackPower);
            pool.ReturnToPool(this.gameObject);
        }

    }

}
