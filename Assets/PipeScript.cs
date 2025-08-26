using UnityEngine;

public class PipeScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Pipe;
    public double spawnRate = 2.5;
    public float timer = 0;
    public float heightOffset = 6;

    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {   
        if(timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
            spawnPipe();
        }
    }
    void spawnPipe() {
            
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);  
        timer = 0;
    }
}
