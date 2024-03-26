using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;

    public static GameManager Instance;

    public TextMeshProUGUI displayedScore;
    
    private void Awake()
    {
        Instance = this;
    }

    public int GetScore()
    {
        return score;
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        displayScore();
    }

    public void ResetScore()
    {
        score = 0;
    }

    private void displayScore() {
        displayedScore.text = score.ToString();

    }
}