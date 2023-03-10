using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesCollider : GM
{
     public PlayerMovement movement;

    private void OnCollisionEnter(Collision other) {

        if (other.collider.tag == "Obstacle") {


            movement.enabled = false;
            base.EndGame();
        
        }
        
    }
}
