using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
      void OnCollisionEnter2D(Collision2D col)
    {
        // Check if the projectile collides with a GameObject tagged as "Wall"
        if (col.gameObject.CompareTag("Wall"))
        {
            // Destroy the projectile GameObject upon collision with the wall
            Destroy(gameObject);
        } else if (col.gameObject.CompareTag("Player")){
            //On change la position du joueur et on le téléporte aux coordonnées sauvegardées dans le TableauManager dans la variable checkpointPosition.
            col.gameObject.transform.position = TableauManager.GetCheckpointPosition();
			
			//On augmente de 1 le compteur de morts
			col.gameObject.GetComponent<PlayerManager>().RemoveLive(); //On récupère le PlayerManager du joueur pour ajouter la mort
			
			//On immobilise le joueur pendant 0.5 s
			PlayerManager.SetFreeze(0.5f);
            Destroy(gameObject);
            
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
