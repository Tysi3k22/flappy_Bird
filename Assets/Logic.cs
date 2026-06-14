using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Logic : MonoBehaviour
{
    public int Score = 0;
    public Text text;
    public Text heighestScoreText;
    public GameObject gameOverScreen;
    public bool active = true;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void addScore(bool active = true)
    {
        if(active)
        {
            Score++;
            text.text = Score.ToString();
        }
    }


    public void playAgain()
    { 
        SceneManager.LoadScene("StartGameScene");
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        updateSavedScore(Score);
    }

    public void updateSavedScore(int score)
    {
        if (score >= PlayerPrefs.GetInt("heighstScore"))
        {
            PlayerPrefs.SetInt("heighstScore", score);
        }
    }

    public int getHeighestScore()
    {
        return PlayerPrefs.GetInt("heighstScore");
    }
}
