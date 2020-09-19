using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    private static GameHandler instance;

    [SerializeField] private Snake snake;
    private LevelGrid levelGrid;
    
    private void Awake() {
        instance = this;
        Score.InitializeStatic();
        Time.timeScale = 1f;
    }


    void Start()
    {
            levelGrid = new LevelGrid(20, 20);

            snake.Setup(levelGrid);

            levelGrid.Setup(snake);      
    }

    private void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isGamePaused()){
                ResumeGame();
                PauseWindow.HidePauseWindowStatic();
            } else{
                PauseGame();
                PauseWindow.ShowPauseWindowStatic();
            }
        }
    }

    public static void SnakeDied(){
        Score.TrySetNewHighScore();
        GameOverWindow.ShowStatic();
    }

    public static void ResumeGame(){
        Time.timeScale = 1f;
    }

    public static void PauseGame(){
        Time.timeScale = 0f;
    }

    private bool isGamePaused(){
        return Time.timeScale == 0;
    }

    public static void SetDifficulty(int i){
        PlayerPrefs.SetInt("difficulty", i);
        PlayerPrefs.Save();
    }

    public static int GetDifficulty(){
        return PlayerPrefs.GetInt("difficulty", 1);
    }

}
