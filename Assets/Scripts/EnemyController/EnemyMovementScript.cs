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
    PlayerScript target;
    void Awake()
    {
        animationController = GetComponentInChildren<MovementAnimationController>();
        target = FindObjectOfType<PlayerScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if (ai.hasPath)
        {
            
            animationController.SetDirection(ai.destination);
        }
    }
    void FixedUpdate()
    {
        if (target != null && ai != null) ai.destination = target.transform.position;
    }
   
}
