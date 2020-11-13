using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : ShootingController
{

    [SerializeField]
    PlayerScript playerScript;
    
    private bool isShooting = false;
    private Vector2 shootingDestination;

    
    void Start()
    {
        playerScript.mouseClickSender.MouseClickRightEvent += MouseClickRight;
    }
    private void FixedUpdate()
    {
        
        if (isShooting == true)
        {
            playerScript.movementScript.StopMoving();
            Shoot(shootingDestination);
            isShooting = false;
        }
            
    }

    public void MouseClickRight(Vector2 mousePos)
    {
        isShooting = true;
        shootingDestination = mousePos;
    }

    
    void OnDisable()
    {
        playerScript.mouseClickSender.MouseClickRightEvent -= MouseClickRight;
    }
}
