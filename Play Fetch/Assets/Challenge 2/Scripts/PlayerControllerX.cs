using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // A boolean to check for true/false
    private bool isSpawned = false;
    private float spawnTimer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        SpawnDog();
    }

    private void SpawnDog()
        {
            // checking for key press and the bool. If the space key is pressed and the bool is true.
            if (Input.GetKeyDown(KeyCode.Space) && !isSpawned) 
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                // we reset the timer to default while isSpawned is true making it imposible to spawn another dog
                spawnTimer = 0.0f;
                isSpawned = true;
            }
            // we return a new spawnTimer 
            spawnTimer += Time.deltaTime;
            // condition to check if the last spawned was over 0.5 seconds, isSpawned returns to default to enable another dog to be spawned
            if (spawnTimer > 0.5f)
            {
                isSpawned = false;
            }

        }
    
}
