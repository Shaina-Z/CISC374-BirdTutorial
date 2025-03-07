using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStateManagerScirpt : MonoBehaviour
{
    public int pointsScored=0;
    public Text scoreText;
    public Text highScore;
    public GameObject GameOverScreen;
    public GameObject StartScreen;
    AudioSource GameOver_Sound;
    public int currentHighScore;
    void Start()
    {
       currentHighScore=PlayerPrefs.GetInt("high score");
         Time.timeScale = 0;
        GameOver_Sound = GetComponent<AudioSource>();
        
    }
 
[ContextMenu("Increase Score")]
    public void addPoint(){
        pointsScored++;
        scoreText.text=pointsScored.ToString();
    }

 public void startGame(){
    Time.timeScale = 1;
    StartScreen.SetActive(false);
    highScore.text="High Score: "+PlayerPrefs.GetInt("high score").ToString();
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
    
        GameOver_Sound.Play();
        GameOverScreen.SetActive(true);
         PlayerPrefs.SetInt("high score",currentHighScore);
        PlayerPrefs.Save();
        Time.timeScale = 0;
        
    }

    public void setHighScore(){
        if(pointsScored>currentHighScore){
            currentHighScore=pointsScored;
            highScore.text="High Score: "+currentHighScore.ToString();
        }
         
        
}
}
