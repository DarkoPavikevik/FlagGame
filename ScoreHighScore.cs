using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreHighScore : MonoBehaviour
{
    public Text score,highScore;
    public string playerName;
    public int playerPoints; 
    public string playerHighestName;
    public int playerHighestPoints; 
    // Start is called before the first frame update
    void Start()
    {
        playerName = PlayerPrefs.GetString("KeyName", "Ne uspea");
        
        playerPoints= PlayerPrefs.GetInt("KeyPoints", 0);
        playerHighestPoints = PlayerPrefs.GetInt("KeyHighestPoints", 0);
        score.text = playerName + ": " + playerPoints.ToString();
        highScore.text = playerHighestPoints.ToString();
    }   

   
}
