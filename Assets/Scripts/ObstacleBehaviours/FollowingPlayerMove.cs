
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingPlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 direction;
	private float delay = 0.5f;
	private float timerDelay = 0;
    private bool isFollowing = false; // Indicateur de suivi

		private Vector2 initPosition; //position initiale

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Activer le suivi lorsque Fiona entre en collision avec le joueur
            isFollowing = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Désactiver le suivi lorsque Fiona quitte la collision avec le joueur
            isFollowing = false;
        }
    }

    void FixedUpdate()
    {
        if (isFollowing)
        {
            // Déplacer Fiona seulement si elle doit suivre le joueur
            direction = (PlayerManager.GetPlayer().transform.position - transform.position).normalized;
            rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
        }
    }


	//Fonction qui remet l'objet à sa position initiale
	public void reinitPosition(){
		transform.position = initPosition;
		timerDelay += delay;
	}
}