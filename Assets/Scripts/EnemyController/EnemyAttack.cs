using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyAttack : ShootingController
{
    public AIPath ai;
    

    [SerializeField]
    private float shootDistance = 3;
    [SerializeField]
    private float shootCoolDown = 3;
    private float nextShotTime = 0;
 
    void Update()
    {
        var distance = Vector3.Distance(ai.steeringTarget, transform.position);
        if (Time.time > nextShotTime)
        {
            if (distance < shootDistance)
            {
                Shoot(ai.steeringTarget);
                nextShotTime = Time.time + shootCoolDown;
            }
        }
        
    }

    
}
