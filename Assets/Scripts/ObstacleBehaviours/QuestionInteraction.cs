using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionInteraction : MonoBehaviour
{
    [SerializeField] private GameObject qcmPanel; // Panneau contenant les boutons du QCM
    [SerializeField] private Button answerButtonA; // Bouton de la réponse A (bonne réponse)
    [SerializeField] private Button answerButtonB; // Bouton de la réponse B (mauvaise réponse)
    [SerializeField] private Button answerButtonC; // Bouton de la réponse C (mauvaise réponse)
    private bool isQcmActive = false; // Indique si le QCM est actif ou non

    void Start()
    {
        // Désactiver les boutons du QCM au démarrage
        SetQcmActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Activer les boutons du QCM lorsque le joueur entre en collision avec l'objet "question"
            SetQcmActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Désactiver les boutons du QCM lorsque le joueur quitte la zone de l'objet "question"
            SetQcmActive(false);
        }
    }

    public void CheckAnswer(Button selectedButton)
    {
        if (isQcmActive)
        {
            // Vérifier la réponse sélectionnée
            if (selectedButton == answerButtonA)
            {
                // Réponse correcte (bouton A)
                Debug.Log("Bonne réponse ! Vous pouvez continuer le jeu.");
                ChangeButtonColor(answerButtonA, Color.green); // changement de la couleur de la case de bonne réponse
                // Traitez la réponse correcte
            }
            else
            {
                // Réponse incorrecte (boutons B ou C)
                Debug.Log("Mauvaise réponse ! Vous revenez au début du niveau.");
                ChangeButtonColor(answerButtonA, Color.red); // changement de la couleur de la case de la mauvaise réponse
                // Traitez la réponse incorrecte
            }
            // Désactiver les boutons du QCM après avoir sélectionné une réponse
            SetQcmActive(false);
        }
    }

    private void ChangeButtonColor(Button button, Color color)
{
    // Accéder au composant Image du bouton
    Image buttonImage = button.GetComponent<Image>();
    if (buttonImage != null)
    {
        // Changer la couleur de l'image du bouton
        buttonImage.color = color;
    }
}

    private void SetQcmActive(bool active)
    {
        // Activer ou désactiver les boutons du QCM en fonction de l'état actif
        answerButtonA.gameObject.SetActive(active);
        answerButtonB.gameObject.SetActive(active);
        answerButtonC.gameObject.SetActive(active);
        isQcmActive = active;
    }
}