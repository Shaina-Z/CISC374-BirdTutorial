using UnityEngine;
using UnityEngine.UI;

public class GameStateManagerScirpt : MonoBehaviour
{
    private int pointsScored=0;
    public Text scoreText;
    public void addPoint(){
        pointsScored++;
    }
}
