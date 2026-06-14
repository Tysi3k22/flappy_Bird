using UnityEngine.SceneManagement;
using UnityEngine;
public class StartGameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void playGame()
    {
        Debug.Log("xpp");
        SceneManager.LoadScene("gameScene");
    }
}
