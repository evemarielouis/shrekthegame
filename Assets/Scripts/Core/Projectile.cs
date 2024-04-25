using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    [SerializeField] GameObject donkeyKiss;
    void Start()
    {
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