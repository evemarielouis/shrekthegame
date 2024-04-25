using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class tomenu : MonoBehaviour

{
    // Méthode appelée lorsque le bouton est cliqué
    public void EndGame()
    {
        // Charger la scène du menu principal
        SceneManager.LoadScene("TitleMenuFinal"); // Remplacez "MainMenu" par le nom de votre scène de menu principal
    }
    public void RetourauMenu()
	{
		//Mettre entre guillemets le nom de la scène vers laquelle charger
		//Pour utiliser SceneManager, il faut impérativement rajouter "using UnityEngine.SceneManagement;" en haut du script.
		SceneManager.LoadScene("TitleMenuFinal");
	}
    public void RetourauNiv1()
	{
		//Mettre entre guillemets le nom de la scène vers laquelle charger
		//Pour utiliser SceneManager, il faut impérativement rajouter "using UnityEngine.SceneManagement;" en haut du script.
		SceneManager.LoadScene("SceneToEdit_Eve 1");
	}
}

