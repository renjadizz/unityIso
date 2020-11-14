using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObjectPool gameObjectPool;
    [SerializeField]
    private float respawnTime = 5f;
    private float nextSpawnTime;
    private int enemyDeath = 0;

    [SerializeField]
    GameEvent stageIsCleared = default(GameEvent);
    void Update()
    {
        if(Time.time >= nextSpawnTime)
        {
            nextSpawnTime = Time.time + respawnTime;
            var newEnemy = gameObjectPool.Get();
            newEnemy.transform.position = transform.position;
            newEnemy.transform.rotation = transform.rotation;
            newEnemy.SetActive(true);
        }
        
    }

    public void EnemyDeathCounter()
    {
        enemyDeath += 1;
        if(enemyDeath >= 10)
        {
            stageIsCleared.Raise();
        }
    }
}
