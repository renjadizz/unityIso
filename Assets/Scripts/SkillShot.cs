using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillShot : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 20f;
    [SerializeField]
    float liveTime = 0.3f;
    [SerializeField]
    float attackPower = 10f;

    float spawnTime = 0f;
    bool isShot = false;

    public void Start()
    {
        spawnTime = Time.time;
    }
    public void Setup(Vector3 shootDir)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(shootDir * moveSpeed, ForceMode2D.Impulse);
        isShot = true;
    }
    public void FixedUpdate()
    {
        if (isShot == true && Time.time > spawnTime + liveTime)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ITakeDamage damagable = collision.GetComponent<ITakeDamage>();
        if (damagable != null)
        {
            damagable.TakeDamage(attackPower);
            Destroy(gameObject);
        }

    }

}
