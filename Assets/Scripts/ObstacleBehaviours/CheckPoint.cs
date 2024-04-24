using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public delegate void TriggerEventHandler();
    public static event TriggerEventHandler OnTriggerEvent;
    private bool StopTrigger = false;

    public void OnTriggerEnter2D(Collider2D col) {
		//Si l'obstacle entre en collision avec le joueur (objet avec le tag "Player")
        
        if (!StopTrigger){
            if (col.gameObject.tag == "Player") {
			Debug.Log("Player entered the trigger collider!");
            //On immobilise le joueur pendant 0.5 s
			PlayerManager.SetFreeze(0.5f);
            StopTrigger = true;
            OnTriggerEvent?.Invoke();
        }
    }
        }
        
}

