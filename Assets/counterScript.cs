using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class counterScript : MonoBehaviour
{
    private Logic logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
