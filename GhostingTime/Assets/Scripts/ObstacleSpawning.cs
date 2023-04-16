using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// - Attached to the Spawn Point game object
/// - Make prefabs (hellfire) spawn in Spawn Point position
/// - spawn rate: time interval between one spawning and the other
/// - spawn timer: it will be increased by adding delta time
/// - spawn timer -> expired when it will be equal to spawn rate
/// - height offset: to define a min-max height for the spawning position
/// </summary>
public class ObstacleSpawning : MonoBehaviour
{
    public GameObject hellfire;
    public float spawnRate = 2;
    public float spawnTimer = 0;
    private float heightOffset = 7;

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < spawnRate)
        {
            // If timer is running (<2)
            // add delta time (time interval between frames) to the timer:
            spawnTimer += Time.deltaTime;
        } else
        {
            // If timer expired (=2)
            // spawn the object:
            spawnObstacle();
            // now reset the timer:
            spawnTimer = 0;
        }
    }

    void spawnObstacle()
    {
        float bottomMargin = transform.position.y - heightOffset;
        float topMargin = transform.position.y + heightOffset;

        // Different spawning positions:
        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(bottomMargin, topMargin), 0);

        // To instantiate/clone the prefab:
        Instantiate(hellfire, spawnPosition, transform.rotation);
        Debug.Log("[DEBUG] Prefab spawned in: " + spawnPosition);
    }
}
