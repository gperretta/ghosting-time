using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// - Attached to the 'middle' component of the HellFire prefab 
/// - logic handler: to use the GameLogicHandler script
/// - Call a function from said script when collision is triggered
/// 
/// - Collision: Ghost (tag: "Player") - collider of the game object is attached to
///
/// - Function: increaseScore() defined in GameLogicHandler script
/// </summary>
public class ScoringHandler : MonoBehaviour
{
    public GameLogicHandler logicHandler;

    private void Start()
    {
        // To add the script (contained in a game object) to the instantiated prefab(s)
        logicHandler = GameObject.Find("Logic Manager").GetComponent<GameLogicHandler>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            logicHandler.increaseScore();
        }
    }
}
