using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
	[SerializeField] private GameObject levelText; //On insère l'objet texte qui affiche le numéro du niveau
	[SerializeField] private GameObject timerText; //On insère l'objet texte qui affiche le compteur de temps

	[SerializeField] private GameObject[] imagesDialog1;

	private int numImageDialog1 = 0;
	private bool showingDialog1 = false;

	void Update()
    {
        if (showingDialog1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ShowNextDialog1(); 
            }
        }
    }



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


	public void showDialog1(int numImage){
		for(int i = 0; i < imagesDialog1.Length; i++){
			if(numImage == i){
				imagesDialog1[i].SetActive(true);
			} else {
				imagesDialog1[i].SetActive(false); //NATHAN
			}
		}
	}

	public void ShowNextDialog1(){
		showDialog1(numImageDialog1);
		numImageDialog1++;
		showingDialog1 = numImageDialog1 <= imagesDialog1.Length;
	}
}