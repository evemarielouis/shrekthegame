using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FionaMovement : MonoBehaviour

{
    private bool isFollowing = false; // Indique si Fiona doit suivre le joueur
    public float followSpeed = 5f; // Vitesse à laquelle Fiona suit le joueur
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (isFollowing)
        {
            // Déplacez Fiona vers la position actuelle du joueur
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, followSpeed * Time.deltaTime);
        }
    }

    // Méthode pour définir si Fiona doit suivre le joueur ou non
    public void SetFollowing(bool follow)
    {
        isFollowing = follow;
    }
}

