using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TMP_Text timerText;
    public TMP_Text resultText;
    public Transform player;
    float timeLeft = 60f;
    bool gameOver = false;
    void Update()
    {
        if (gameOver)
            return;

        timeLeft -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (player.position.y < -1f)
        {
            resultText.text = "YOU LOST!";
            gameOver = true;
            Time.timeScale = 0;
        }
        if (timeLeft <= 0)
        {
            resultText.text = "YOU WON!";
            gameOver = true;
            Time.timeScale = 0;
        }
    }
}