using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
	[SerializeField] private GameObject levelText; //On insère l'objet texte qui affiche le numéro du niveau
	[SerializeField] private GameObject timerText; //On insère l'objet texte qui affiche le compteur de temps

	  [SerializeField] private GameObject livesText; // Nouveau champ pour afficher le nombre de vies
	
		// Nouvelle méthode pour mettre à jour le texte des vies
	public void updatelivesText(int nbLives)
    {
        livesText.GetComponent<TMP_Text>().text = "Vies : " + nbLives;
    }
	
	public void updateLevelText(int numLevel){
		levelText.GetComponent<TMP_Text>().text = "Niveau " + numLevel;
	}
	
	public void updateTimer(float time){
		//Permet d'arrondir le temps à deux chiffres après la virgule
		timerText.GetComponent<TMP_Text>().text = "Temps " + time.ToString("F2")  +"s";
	}


}
