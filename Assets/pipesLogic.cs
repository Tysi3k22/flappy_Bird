using UnityEngine;

public class pipesLogic : MonoBehaviour
{
    public GameObject pipe;
    public float timer = 0;
    public float pps = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        createPipe();
        

    }

    void createPipe()
    {
        if (timer < pps)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            Instantiate(pipe, transform.position, transform.rotation);
        }

    }
}
