using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    
    public void addScore() {
        playerScore++;
        scoreText.text = playerScore.ToString();

    }
    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver() {
        gameOverScreen.SetActive(true);
    }
}
