using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] public int highScore = 0;
    public int currentScore;
    TMP_Text highScoreText;
    TMP_Text currentScoreText;

    
    // Start is called before the first frame update
    void Start()
    {
        highScoreText = GameObject.Find("HighScore").GetComponent<TMP_Text>();
        currentScoreText = GameObject.Find("CurrentScore").GetComponent<TMP_Text>();
        currentScore = 0;
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = "High Score: " + highScore;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int amount){
        currentScore += amount;
        CurrentScoreUpdate();
    }

    public void ResetCurrentScore(){
        currentScore = 0;
        CurrentScoreUpdate();
    }

    public void CurrentScoreUpdate(){
        currentScoreText.text = "Score: "+currentScore;
    }

    public void HighScoreUpdate(){
        if (currentScore > highScore){
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = "High Score: " + highScore;
        }
    }
}
