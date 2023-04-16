using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// - Attached to the Ghost game object (Tag: "Player")
/// - ghost rigid body: to allow collision(s) and give it physics
/// - ghost strenght: how high it can "jump"
/// - logic handler: to use the GameLogicHandler script
/// - game is over: when true, game over screen has to displayed
/// - gave over -> controls cannot work when game is over is true
/// 
/// - Player controls: space bar to go up
/// </summary>
public class GhostController : MonoBehaviour
{
    public Rigidbody2D ghostRigidBody;
    public float ghostStrenght;
    public GameLogicHandler logicHandler;
    public bool gameIsOver = false;

    // Start is called before the first frame update
    void Start()
    {
        logicHandler = GameObject.Find("Logic Manager").GetComponent<GameLogicHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameIsOver)
        {
            ghostRigidBody.velocity = Vector2.up * ghostStrenght;
        }
    }

    // When the ghost collides with the obstacles
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Game over:
            logicHandler.gameOver();
            gameIsOver = true;
        }
    }
}
