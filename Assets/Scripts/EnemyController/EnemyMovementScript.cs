using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using System;
public class EnemyMovementScript : MonoBehaviour
{

    [NonSerialized]
    public MovementAnimationController animationController;
    
    public AIPath ai;
    

    void Awake()
    {
        animationController = GetComponentInChildren<MovementAnimationController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ai.hasPath)
        {
            animationController.SetDirection(ai.destination);
        }
    }
   
}
