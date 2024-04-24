using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrekAction : MonoBehaviour
{

    [SerializeField] private Transform DonkeySpawnPoint;
    [SerializeField] private GameObject DonkeyPrefab;
    [SerializeField] private float Speed = 20f;
    private bool triggerActivated = false;

    // Start is called before the first frame update
    void Start()
    {
         CheckPoint.OnTriggerEvent += HandleTriggerEvent;
    }

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && triggerActivated) {
                Debug.Log("Key is pressed");
                var donkey = Instantiate(DonkeyPrefab, DonkeySpawnPoint.position, DonkeySpawnPoint.rotation);
                Rigidbody2D donkeyRB = donkey.GetComponent<Rigidbody2D>();
                donkeyRB.velocity = new Vector2(-Speed, 0); // Move from left to right
            }
        } 
        
    void HandleTriggerEvent()
    {
         // Perform an action when the player enters the trigger collider
        Debug.Log("YO WE ENTERED");
        triggerActivated = true; 
        Debug.Log("triggerActivated is set to true");
        // Optionally, you can add additional actions here when the trigger is activated
    }
}
