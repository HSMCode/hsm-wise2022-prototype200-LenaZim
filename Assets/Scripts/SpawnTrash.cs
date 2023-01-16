using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour

{
    //Array for trash Prefabs to Randomly choose from 
[SerializeField] GameObject [] Trash;
[SerializeField] float trashSpawnBoundsRadius;
 
// counter for spawned trash
[SerializeField] int spawnedTrash;

// This repeat rate is only changeable before starting the scene, to change the repeat rate on runtime we need a different solution
[SerializeField] float repeatRateOnStart = 2f;

// Start is called before the first frame update
    void Start()
    {
    // With Invoke Repeating only the parameters generated inside the method can be controlled
    InvokeRepeating("SpawningTrash", 3f, repeatRateOnStart);
    }

    private Vector3 GenerateSpawnPosition()
    {
        // Get radius from SphereCollider
        var collider = GetComponent<SphereCollider>();
        trashSpawnBoundsRadius = collider.radius;

        // Create a random Trash spawn position
         Vector3 trashSpawnPos = new Vector3(Random.Range(-trashSpawnBoundsRadius, trashSpawnBoundsRadius), 0,
            Random.Range(-trashSpawnBoundsRadius, trashSpawnBoundsRadius));
        // Check if random position is inside the collider, if not update position to closest point available
        Vector3 trashSpawnPosClosest = collider.ClosestPoint(trashSpawnPos);

        // Debug Log to check coordinates
        // Debug.Log("Random Pos: " + trashSpawnPos + "Closest Position to Collider : " + trashSpawnPosClosest);
        
        return trashSpawnPosClosest;
    }
    void SpawningTrash()
    {

            // Get a random slot from the enemy prefab array
            int number = Random.Range(0, Trash.Length);

            // Instantiate a clone from the prefab enemies at the previously generated position
            Instantiate(Trash[number], GenerateSpawnPosition(), Trash[number].transform.rotation);

            spawnedTrash++;
    }
}


    