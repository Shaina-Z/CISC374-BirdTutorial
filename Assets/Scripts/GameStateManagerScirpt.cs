using UnityEngine;
using UnityEngine.UI;

public class GameStateManagerScirpt : MonoBehaviour
{
    private int pointsScored=0;
    public Text scoreText;

[ContextMenu("Increase Score")]
    public void addPoint(){
        pointsScored++;
        scoreText.text=pointsScored.ToString();
    }
}
