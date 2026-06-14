using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VectorGraphics;

public class Logic : MonoBehaviour
{
    public float Score = 0;
    public Text text;
    public GameObject gameOverScreen;
    public bool active = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void setNonActive(bool active)
    {
        active = false;
    }
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
        SceneManager.LoadScene("SampleScene");
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
