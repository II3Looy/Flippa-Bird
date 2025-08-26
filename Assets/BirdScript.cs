using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Rigidbody2D myRigidbody;
    public int velocity = 16;
    public LogicScript Logic;
    public bool birdIsAlive = true;

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive) {
            myRigidbody.linearVelocityY = velocity;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision) {
        birdIsAlive = false;
        Logic.gameOver();
    }
}
