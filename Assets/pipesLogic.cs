using UnityEngine;

public class pipesLogic : MonoBehaviour
{
    public GameObject pipe;
    public float timer = 0;
    public float pps = 3;
    private float min = -3f;
    private float max = 3f;
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
            Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(min, max), transform.position.z), transform.rotation);
        }

    }
}
