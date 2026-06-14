using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class Logic : MonoBehaviour
{
    public float Score = 0;
    public Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void addScore()
    {
        Score++;
        text.text = Score.ToString();
    }
}
