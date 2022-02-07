using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplayer : MonoBehaviour
{
    public bool youAreDeadScreReset = false;
    public int score;
    public int highScoreInt;

    public TextMeshProUGUI scoreTex;
    public TextMeshProUGUI highScoreTex;
    void Start()
    {

        highScoreTex.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highScore11", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        youAreDeadScreReset = Kill.youAreDeadScoreReset;
        if (youAreDeadScreReset) { score = 0; }
        score = KillEnemies.score;


        if (score < 0) { score = 0; }
        scoreTex.text = "SCORE: " + score.ToString("0");
    
        if (score > PlayerPrefs.GetInt("highScore11", 0))
        {


            PlayerPrefs.SetInt("highScore11", score);
            highScoreTex.text = "HIGHSCORE: " + score.ToString("0");
        }
    }
}