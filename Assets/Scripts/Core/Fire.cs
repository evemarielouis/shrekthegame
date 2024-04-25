using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
      void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the projectile collides with a GameObject tagged as "Wall"
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Destroy the projectile GameObject upon collision with the wall
            Destroy(gameObject);
        } else if (collision.gameObject.CompareTag("Player")){
            // DO SOMETHING
            
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
