using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    void Start(){

	}
      void OnCollisionEnter2D(Collision2D col)
    {
        // Check if the projectile collides with a GameObject tagged as "Wall"
        if (col.gameObject.tag == "Donkey")
        {
            Debug.Log("oh my god they're KISSING");
           // ANIMATION QUAND DRAGON EST MORT ICI NATHAN ICI 
           
        } 


    }
}
