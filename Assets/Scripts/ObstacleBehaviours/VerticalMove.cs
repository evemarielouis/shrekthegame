using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMove : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 5f; //Vitesse de l'objet, modifiable
	[SerializeField] private int ySens = 1; //Le sens de l'objet (1 si en bas, -1 si en haut)
	[SerializeField] private Rigidbody2D rb; //Le rigidbody pour bouger l'obstacle

	// DELAY AVANT DE COMMENCER A BOUGER (ENNEMIS)
	[SerializeField] private float delay = 0f; 
	[SerializeField] private float pause = 0f;

	private float pauseTimer = 0f;
	private Vector2 movement;

	private bool triggerActivated = false;

	[SerializeField] private Transform FinalPositionDragon;

	//Au démarrage, défini la variable de mouvement
	void Start()
	{
		movement = new Vector2(0, ySens);
        // Subscribe to the event defined in the trigger script
        CheckPoint.OnTriggerEvent += HandleTriggerEvent;
	}

	//A chaque frame, on bouge l'objet via son rigidbody dans le mouvement défini * la vitesse de l'objet moveSpeed * Time.fixedDeltaTime le laps de temps écoulé en 1 frame

	void FixedUpdate()
	{
		if (!triggerActivated)
		{
			if (delay > 0)
			{
				delay = delay - Time.fixedDeltaTime;
			}
			else if (pauseTimer > 0)
			{
				pauseTimer = pauseTimer - Time.fixedDeltaTime;
			}
			else
			{
				rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
			}
		} else {
			transform.position = FinalPositionDragon.position;
			rb.isKinematic = true;
		}

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//Si l'obstacle rentre en collision avec un mur, on inverse son mouvement vertical pour qu'il aille dans le sens contraire

		if (col.gameObject.tag == "Wall") {
			movement.y = movement.y*-1; 

			pauseTimer = pause;
		}
	}
 	void HandleTriggerEvent()
		{
			// Handle the trigger sent by the empty GameObject
			Debug.Log("Player entered the trigger area of the empty GameObject.");
			triggerActivated = true;
		}
}

	