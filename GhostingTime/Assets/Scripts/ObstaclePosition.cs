using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// - Attached to the HellFire prefab element
/// - It will run each time the prefab will be instantiated/cloned
/// - move speed: how fast the prefabs will move (to left)
/// - off screen: define when/where the prefab can be destroyed (where it cannot be seen)
/// </summary>
public class ObstaclePosition : MonoBehaviour
{
    public float moveSpeed = 5;
    public float offScreen = -45;

    // Update is called once per frame
    void Update()
    {
        // Move to left:
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < offScreen)
        {
            Debug.Log("[DEBUG] Prefab deleted off-screen");
            Destroy(gameObject);
        }
    }
}
