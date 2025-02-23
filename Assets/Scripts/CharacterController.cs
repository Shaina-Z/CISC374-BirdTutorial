using UnityEngine;


public class CharacterController : MonoBehaviour
{
    public GameObject player;
    public float jumpForce = 20;
    public bool birdIsAlive=true;
    public GameStateManagerScirpt gameStateManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameStateManager = GameObject.FindGameObjectWithTag("GameStateManager").GetComponent<GameStateManagerScirpt>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true&&birdIsAlive)
        {
            Jump();
        }
        void Jump()
        {
            player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * 10;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        gameStateManager.gameOver();
        birdIsAlive=false;
    }
}
