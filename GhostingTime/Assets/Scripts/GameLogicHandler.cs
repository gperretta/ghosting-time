using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// - Attached to Logic Manager game object
/// - score label: TextMeshPro object to update
/// - score: int value to increase in increaseScore function
/// - gameOverScreen: game over canvas (initially not active)
/// - increaseScore function: add 1 to score (int) and update score label
/// - NOTE: to update score label (scoreLabel.text) a type casting is needed (int->String)
/// - gameOver function: to activate GameOverScreen  
/// </summary>
public class GameLogicHandler : MonoBehaviour
{

    public TextMeshProUGUI scoreLabel;
    public int score = 0;
    public GameObject gameOverScreen;

    public void increaseScore()
    {
        score += 1;
        scoreLabel.text = score.ToString();
        Debug.Log("[DEBUG] Score increased at " + score.ToString());
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void restartGame()
    {
        // Reload the game scene:
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
