using UnityEngine;

public class PipeMiddleScirpt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameStateManagerScirpt gameStateManager;
    AudioSource Point_Sound;
    void Start()
    {
        Point_Sound = GetComponent<AudioSource>();
        gameStateManager = GameObject.FindGameObjectWithTag("GameStateManager").GetComponent<GameStateManagerScirpt>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameStateManager.addPoint();
        gameStateManager.setHighScore();
        Point_Sound.Play();
    }
}
