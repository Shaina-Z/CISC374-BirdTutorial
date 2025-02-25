using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStateManagerScirpt : MonoBehaviour
{
    public int pointsScored=0;
    public Text scoreText;
    public GameObject GameOverScreen;
    AudioSource GameOver_Sound;
    void Start()
    {
        GameOver_Sound = GetComponent<AudioSource>();
    }
 
[ContextMenu("Increase Score")]
    public void addPoint(){
        pointsScored++;
        scoreText.text=pointsScored.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        GameOver_Sound.Play();
        GameOverScreen.SetActive(true);
    }
}
