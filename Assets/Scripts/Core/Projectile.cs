using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{

    [SerializeField] private GameObject[] dialogues;
    [SerializeField] GameObject donkeyKiss;
    public float showDuration = 5f; // Duration in seconds to show the sprite
    private int currentIndex = 0;      // Index of the current sprite being shown

    void Start()
    {
        HideAllSprites();
        dialogues[1].SetActive(true);
        dialogues[2].SetActive(true);
        donkeyKiss.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)

    {
        // Check if the projectile collides with a GameObject tagged as "Wall"
        if (col.gameObject.tag == "Donkey")
        {
            Debug.Log("oh my god they're KISSING");
                      // ANIMATION QUAND DRAGON EST MORT ICI NATHAN ICI 
            donkeyKiss.SetActive(true);
            StartCoroutine(WaitAndLoadScene(2f));
            dialogues[0].SetActive(true);
            Invoke("HideAllSprites", showDuration);

        }
    }


private void ShowNextSprite()
    {
        // Hide the current sprite
        HideCurrentSprite();

        // Show the next sprite in the list
        if (currentIndex < dialogues.Length)
        {
            dialogues[currentIndex].SetActive(true);
            currentIndex++;
        }
    }

    private void HideCurrentSprite()
    {
                // Hide the current sprite
        if (currentIndex > 0 && currentIndex <= dialogues.Length)
        {
            dialogues[currentIndex - 1].SetActive(false);
        }
    }

        private void HideAllSprites()
    {
        // Hide all sprites
        foreach (var dialogue in dialogues)
        {
            dialogue.SetActive(false);
        }

    }
    
    // Coroutine pour attendre et charger la nouvelle scène
    IEnumerator WaitAndLoadScene(float waitTime)
    {
        // Attendre pendant le temps spécifié
        yield return new WaitForSeconds(waitTime);
        
        // Charger la nouvelle scène
        SceneManager.LoadScene("SceneToEdit_Dina");
    }
}