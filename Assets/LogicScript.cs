using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject instructions;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void hideInstructions()
    {
        Debug.Log("hideInstructions called");
        instructions.SetActive(false);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void endGame()
    {
        gameOverScreen.SetActive(true);
    }
}
