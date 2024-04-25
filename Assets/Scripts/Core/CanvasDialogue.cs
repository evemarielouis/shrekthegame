using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasDialogue : MonoBehaviour
{
    [SerializeField] private GameObject[] spriteObjects; // Reference to the GameObject containing the sprite component
    public float showDuration = 2f; // Duration in seconds to show the sprite
    private int currentIndex = 0;      // Index of the current sprite being shown


    // Start is called before the first frame update
    void Start()
    {
        HideAllSprites();
       spriteObjects[0].SetActive(true);
       CheckPoint.OnTriggerEvent += HandleTriggerEvent;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentIndex <= 1)
        {
            ShowNextSprite();
            Invoke("HideCurrentSprite", showDuration); // Automatically hide the sprite after showDuration seconds
        }
    }
   void HandleTriggerEvent()
    {
         // Perform an action when the player enters the trigger collider
        Debug.Log("dialogue time");
        Debug.Log("its activated letz goooo");
        spriteObjects[2].SetActive(true);
        Invoke("HideAllSprites", showDuration); // Automatically hide the sprite after showDuration seconds
        // Optionally, you can add additional actions here when the trigger is activated
    }
private void ShowNextSprite()
    {
        // Hide the current sprite
        HideCurrentSprite();

        // Show the next sprite in the list
        if (currentIndex < spriteObjects.Length)
        {
            spriteObjects[currentIndex].SetActive(true);
            currentIndex++;
        }
    }

    private void HideCurrentSprite()
    {
        // Hide the current sprite
        if (currentIndex > 0 && currentIndex <= spriteObjects.Length)
        {
            spriteObjects[currentIndex - 1].SetActive(false);
        }
    }

    private void HideAllSprites()
    {
        // Hide all sprites
        foreach (var spriteObject in spriteObjects)
        {
            spriteObject.SetActive(false);
        }
    }
}
