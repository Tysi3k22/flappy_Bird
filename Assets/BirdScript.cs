using UnityEngine;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int flopStrenght = 5;
    private bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flop(isAlive);
    }

    void flop(bool alive)
    {
        if(alive)
        {
            if(Input.GetKeyDown("space"))
            {
                rb.linearVelocity = Vector2.up * flopStrenght;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
    }
}
