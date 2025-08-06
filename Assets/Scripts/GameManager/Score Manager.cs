using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public static int score;
    public int highScore;
    public TextMeshProUGUI scoreTextDisplay;
    public TextMeshProUGUI highScoreTextDisplay;

    private void Awake()
    {
        Instance = this;
        score = 0;
    }

    public void ShowScore()
    {
        scoreTextDisplay.text = "Score: " + score;
        if (score > highScore)
        {
            highScore = score;
            highScoreTextDisplay.text = "High Score: " + highScore;
        }
    }

    // Update is called once per frame
    void Update()
    {
       scoreTextDisplay.text = "Score: " + score;
    }
}
