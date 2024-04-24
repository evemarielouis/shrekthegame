using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
   [SerializeField] private Transform fireSpawnPoint;
   [SerializeField] private GameObject firePrefab;
   [SerializeField] private float fireSpeed = 10f;
   [SerializeField] private float spawnDelay = 3.0f;

  void FixedUpdate() {

    // Decrement the spawn delay timer
    spawnDelay -= Time.fixedDeltaTime;

    // Check if the spawn delay has reached zero
    if (spawnDelay <= 0) {
        // Reset the spawn delay timer
        spawnDelay = 1.0f; // Reset to the initial delay value

        // Debugging: Print position and rotation of fireSpawnPoint
        Debug.Log("Fire Spawn Point Position: " + fireSpawnPoint.position);
        Debug.Log("Fire Spawn Point Rotation: " + fireSpawnPoint.rotation.eulerAngles);

        // Instantiate a new fire object
        var fire = Instantiate(firePrefab, fireSpawnPoint.position, fireSpawnPoint.rotation);
        
        // Set the velocity of the fire object
        Rigidbody2D fireRigidbody = fire.GetComponent<Rigidbody2D>();
        fireRigidbody.velocity = new Vector2(-fireSpeed, 0); // Move from left to right

        // Clamp the fire's position to stay within the x-axis bounds
        fire.transform.position = new Vector3(
            Mathf.Clamp(fire.transform.position.x, -9, 9),
            fire.transform.position.y,
            fire.transform.position.z
            );
		}
	}
}
