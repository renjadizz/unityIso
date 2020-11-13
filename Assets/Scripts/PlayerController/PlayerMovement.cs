using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript;

    public Seeker seeker;
    public AIPath ai;
    public Path path;
   
 
    public void Awake()
    {
        seeker = GetComponent<Seeker>();
        
    }
    void Start()
    {
        playerScript.mouseClickSender.MouseClickLeftEvent += MouseClickLeft;
    }

    public void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
        }
    }
    public void Update()
    {
       if (ai.hasPath && ai.reachedDestination == false)
       {
            playerScript.animationController.SetDirection(ai.steeringTarget - transform.position);
       }

    }
    public void MouseClickLeft(Vector2 mousePos)
    {
        seeker.StartPath(transform.position, mousePos, OnPathComplete);
    }
  
    public void StopMoving()
    { 
        ai.SetPath(null);
    }

    void OnDisable()
    {
        playerScript.mouseClickSender.MouseClickLeftEvent -= MouseClickLeft;
    }


}
