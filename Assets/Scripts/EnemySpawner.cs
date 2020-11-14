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
   
    // Update is called once per frame
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
}
