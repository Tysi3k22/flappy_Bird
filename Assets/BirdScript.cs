using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int flopStrenght = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flop();
    }

    void flop()
    {
        if(Input.GetKeyDown("space"))
        {
            rb.linearVelocity = Vector2.up * flopStrenght;
        }
    }
}
