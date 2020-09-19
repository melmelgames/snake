using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameOverWindow : MonoBehaviour
{
    private static GameOverWindow instance;

    public Button restartBtn;
    public Button mainMenuBtn;

    private void Awake(){
        instance = this;
        Hide();
    }

    private void Start() {
        restartBtn.clicked += RestartBtnOnClick;
        mainMenuBtn.clicked += MainMenuBtn;
    }

    private void RestartBtnOnClick(){
        Loader.Load(Loader.Scene.GameScene);
    }

    private void MainMenuBtn(){
        Loader.Load(Loader.Scene.MainMenu);
    }    

    private void Show(){
        int highscore = Score.GetHighScore();
        int score = Score.GetScore();
        transform.Find("GameOverHighscoreText").GetComponent<Text>().text = "HIGHSCORE: " + highscore.ToString() + "\nSCORE: " + score.ToString();
        if(score >= highscore){
            transform.Find("NewHighscoreText").GetComponent<Text>().text = "NEW HIGHSCORE!";
            transform.Find("NewHighscoreTextShadow").GetComponent<Text>().text = "NEW HIGHSCORE!";
        }else{
            transform.Find("NewHighscoreText").GetComponent<Text>().text = "";
            transform.Find("NewHighscoreTextShadow").GetComponent<Text>().text = "";
        }
        gameObject.SetActive(true);
    }

    private void Hide(){
        gameObject.SetActive(false);
    }

    public static void ShowStatic(){
        instance.Show();
    }    
}
