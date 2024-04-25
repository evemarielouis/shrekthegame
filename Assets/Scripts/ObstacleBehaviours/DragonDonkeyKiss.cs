using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonDonkeyKiss : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the projectile collides with a GameObject tagged as "Wall"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the projectile GameObject upon collision with the wall
            Destroy(gameObject);
        } 

    }
}
