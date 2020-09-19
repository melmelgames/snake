using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScoreWindow : MonoBehaviour
{
    private TextField scoreText;

    private void Awake() {
        scoreText = transform.Find("ScoreText").GetComponent<Text>();

        Score.OnHighScoreChanged += Score_OnHighScoreChanged;
        UpdateHighScore();
    }

    private void Score_OnHighScoreChanged(object sender, System.EventArgs e){
        UpdateHighScore();
    }

    private void Update () {
        scoreText.text = // .text = "Score: " + Score.GetScore().ToString();
        transform.Find("ScoreTextShadow").GetComponent<Text>().text = "Score: " + Score.GetScore().ToString();
    }

    private void UpdateHighScore(){
        int highscore = Score.GetHighScore();
        transform.Find("HighscoreText").GetComponent<Text>().text = "HIGHSCORE\n" + highscore.ToString();
        transform.Find("HighscoreTextShadow").GetComponent<Text>().text = "HIGHSCORE\n" + highscore.ToString();
    }


}
