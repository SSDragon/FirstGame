﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collosionInfo)
    {
        if(collosionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }


}
